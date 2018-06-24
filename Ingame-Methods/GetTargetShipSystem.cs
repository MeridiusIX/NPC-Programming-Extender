//NPC Extender - GetTargetShipSystem

/*
Description:
	 - This method will get the entity Id of a random block 
	 on the target grid that matches the provided targetSystems
	 value. A list of valid arguments for targetSystems can be 
	 found below.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long targetEntityId
		//The grid entityId you want to get the system from.
		
	string targetSystems
		//The type of system you want to get.
*/

/*
Valid Arguments for targetSystems
	"Clang"            //Rotors / Pistons / Wheels
	"Communications"   //Antennas / Beacons / Laser Antennas
	"Controller"       //Seats / Cockpits / Remote Controls
	"Power"            //Reactors / Batteries / Solar
	"Production"       //Refineries / Assemblers / Gas Generators
	"Propulsion"       //Thrusters
	"Weapons"          //Turrets / Fixed Weapons
*/

long GetTargetShipSystem(long targetEntityId, string targetSystems = "Controller"){
	
	var systemsList = new List<string>();
	systemsList.Add("Clang"); //Rotors / Pistons / Wheels
	systemsList.Add("Communications"); //Antennas / Beacons / Laser Antennas
	systemsList.Add("Controller"); //Seats / Remote Controls / Etc
	systemsList.Add("Power"); //Reactors / Batteries / Solar
	systemsList.Add("Production"); //Refineries / Assemblers / Gas Generators
	systemsList.Add("Propulsion"); //Thrusters
	systemsList.Add("Weapons"); //Turrets / Fixed Weapons
	
	if(systemsList.Contains(targetSystems) == false){
		
		return 0;
		
	}
	
	try{
		
		Me.CustomData = targetEntityId.ToString() + "\n" + targetSystems;
		return Me.GetValue<long>("NpcExtender-GetTargetShipSystem");
		
	}catch(Exception exc){
		
		return 0;
		
	}

}