//NPC Extender - GetNearestEnemyGrid

/*
Description:
	 - This method will return the entity Id of the closest grid
	 that is hostile. This can be narrowed down to a specific 
	 faction as well

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string specificFaction
		//The specific faction tag you want to check for. Set to
		//"None" to check all hostile factions.

	double distanceToCheck
		//Only returns grids within this distance
*/

long GetNearestEnemyGrid(string specificFaction = "None", double distanceToCheck = 15000){
	
	try{
		
		Me.CustomData = specificFaction + "\n" + distanceToCheck.ToString();
		return Me.GetValue<long>("NpcExtender-GetNearestEnemy");
		
	}catch(Exception exc){
		
		Echo("NpcExtender-GetNearestEnemy Hard Fail");
		return 0;
		
	}

}