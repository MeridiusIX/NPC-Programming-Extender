//NPC Extender - GetNearestAlliedGrid

/*
Description:
	 - This method will return the entity Id of the closest grids
	 of the same faction.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	double distanceToCheck
		//Only returns grids within this distance
*/

long GetNearestAlliedGrid(double distanceToCheck = 15000){
	
	try{
		
		Me.CustomData = distanceToCheck.ToString();
		return Me.GetValue<long>("NpcExtender-GetNearestAllied");
		
	}catch(Exception exc){
		
		return 0;
		
	}

}