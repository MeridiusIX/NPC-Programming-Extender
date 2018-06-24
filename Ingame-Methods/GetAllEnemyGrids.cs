//NPC Extender - GetAllEnemyGrids

/*
Description:
	 - This method will return a list of entity Ids for all
	 nearby grids that are hostile to the NPC faction.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string specificFaction
		//If you want to get all enemies of a specific faction, enter
		//the faction tag, otherwise leave as "None" to get all enemy
		//grids.
	
	double distanceToCheck
		//Only returns grids within this distance
*/

List<long> GetAllEnemyGrids(string specificFaction = "None", double distanceToCheck = 15000){
	
	try{
		
		Me.CustomData = specificFaction + "\n" + distanceToCheck.ToString();
		return Me.GetValue<List<long>>("NpcExtender-GetAllEnemies");
		
	}catch(Exception exc){
		
		Echo("NpcExtender-GetAllEnemy Hard Fail");
		return new List<long>();
		
	}

}