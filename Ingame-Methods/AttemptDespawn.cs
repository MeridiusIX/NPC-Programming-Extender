//NPC Programming Extender - AttemptDespawn

/*
Description:
	 - This method will attempt to despawn the grid and any 
	attached sub-grids. It will only work if the grid is
	mostly owned by an NPC faction.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	 - None
*/

bool AttemptDespawn(){
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-DespawnDrone");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}