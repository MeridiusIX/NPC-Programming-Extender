//CargoShip Ascend Script

/*
Description:

	This script is designed to be used by NPC ships that are
	spawned from ground installations on planet. Once the script
	begins to run, it will set coordinates high in the sky and
	out in the distance (values configurable below).
	
	Once the ship reaches those coordinates, it will despawn.
	
	This creates the illusion that ships are leaving from a
	ground installation to travel to some unknown destination.

Dependancies:

	- NPC Programming Extender mod

*/

Vector3D despawnCoords = new Vector3D(0,0,0); //This is where despawn coords are kept.
double distanceToTravelUp = 8000; //How High Despawn Is From Ship Spawn
double distanceToTravelRandomForward = 1000; //How Far Despawn Is From Ship Spawn
double distanceFromDespawnTrigger = 500; //How Close Ship Needs To Be From Depsawn To Trigger

string remoteControlName = "Remote Control";
IMyRemoteControl remoteControl;
float remoteControlSpeed = 100;
bool remtoeControlCollisionAvoid = false;

int iceFillTimer = 0;
int iceFillTimerTrigger = 10; //Seconds until next Ice Refill

int tickTimer = 0;

Random rnd = new Random();

public Program(){
	
	Runtime.UpdateFrequency = UpdateFrequency.Update10;
	
}

void Main(){
	
	//Script Runs Once Per 10 Ticks. Adds 10 to tickTimer each run.
	tickTimer += 10;
	
	//If tickTimer is less than 60, the script aborts.
	if(tickTimer < 60){
		
		return;
		
	}
	
	//Tick timer is reset to zero. This allows it to run approx once per second.
	tickTimer = 0;
	
	//Get Remote Control Block If It Hasn't Been Found Yet.
	if(remoteControl == null){
		
		//Get the block
		remoteControl = GridTerminalSystem.GetBlockWithName(remoteControlName) as IMyRemoteControl;
		
		//If it still isn't found, abort script with return.
		if(remoteControl == null){
			
			return;
			
		}
	
	//If remote is found, we do the else case instead
	}else{
		
		//Check if Remote Control works
		if(remoteControl.IsFunctional == false){
			
			//Abort Script if Remote isn't working.
			return;
			
		}
		
	}
	
	iceFillTimer++; // Add 1 to iceFillTimer
	
	//If iceFillTimer is equal to iceFillTimerTrigger or higher
	if(iceFillTimer >= iceFillTimerTrigger){
		
		iceFillTimer = 0; //Reset Ice Fill Timer
		FillGasGenerators(); //Fill Ice
		
	}
	
	//Check if we haven't calcualted despawn coords
	if(despawnCoords == new Vector3D(0,0,0)){
		
		//Run the CalculateDespawnCoords() method below:
		CalculateDespawnCoords();
	
	//IF the despawn coords have been set, we'll send the autopilot to them.
	}else{
		
		//Custom Method for easily setting the autopilot.
		SetDestination(despawnCoords, remtoeControlCollisionAvoid, remoteControlSpeed);
		
		//Check if distance from despawn is less than distanceFromDespawnTrigger. If so, despawn.
		if(Vector3D.Distance(despawnCoords, remoteControl.GetPosition()) < distanceFromDespawnTrigger){
			
			AttemptDespawn();
			
		}
		
	}
	
}

void CalculateDespawnCoords(){
	
	var planetLocation = new Vector3D(0,0,0); //A blank Vector3D we'll use to get the planet coords.
	
	//If the ship is not in natural gravity, then this method will abort here.
	if(remoteControl.TryGetPlanetPosition(out planetLocation) == false){
		
		return; //Abort
		
	}
	
	//To Calculate 'Up', we take the ship position, and subtract the planet position within a Vector3D.Normalize() method.
	var upDirectionVector = Vector3D.Normalize(remoteControl.GetPosition() - planetLocation);
	
	//We use Vector3D.CalculatePerpendicularVector to get a 'forward' direction. We're not sure where forward goes, but it doesn't matter too much.
	var forwardDirectionVector = Vector3D.CalculatePerpendicularVector(upDirectionVector);
	
	//This is going to help us set the despawn coords.
	var despawnMatrix = MatrixD.CreateWorld(remoteControl.GetPosition(), forwardDirectionVector, upDirectionVector);
	
	//The below creates a random direction perpendicular from Up.
	var randomDirectionOffset = new Vector3D(0,0,0);
	randomDirectionOffset.X = (double)rnd.Next(-1000, 1000);
	randomDirectionOffset.Z = (double)rnd.Next(-1000, 1000);
	var randomDirection = Vector3D.Normalize(Vector3D.Transform(randomDirectionOffset, despawnMatrix));
	
	//This sets coordinates at the specified height from where the drone is.
	var despawnUpPosition = Vector3D.Transform(new Vector3D(0,distanceToTravelUp,0), despawnMatrix);
	
	//And then the final spawn coords are calculated by drawing a line at the specified distance, in the random direction, starting at the despawnUpPosition coords.
	var finalSpawnCoords = randomDirection * distanceToTravelRandomForward + despawnUpPosition;
	
	//Save the despawn coords to the despawnCoords variable in globals
	despawnCoords = finalSpawnCoords;
	
}

void SetDestination(Vector3D coords, bool collisionModeEnable = false, float speedLimit = 100){
	
	remoteControl.ClearWaypoints();
	remoteControl.AddWaypoint(coords, "Destination");
	remoteControl.FlightMode = FlightMode.OneWay;
	remoteControl.SetAutoPilotEnabled(true);
	remoteControl.SetCollisionAvoidance(collisionModeEnable);
	remoteControl.SpeedLimit = speedLimit;
	
}

//NPC Programming Extender Methods

bool AttemptDespawn(){
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-DespawnDrone");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}

bool FillGasGenerators(){
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-IceRefill");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}