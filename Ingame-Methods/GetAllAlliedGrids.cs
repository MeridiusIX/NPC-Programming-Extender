//NPC Extender - GetAllAlliedGrids

/*
Description:
	 - This method will return a list of entity Ids for all
	 nearby grids that are part of the same faction.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	double distanceToCheck
		//Only returns grids within this distance
*/

List<long> GetAllAlliedGrids(double distanceToCheck = 15000){
	
	try{
		
		Me.CustomData = distanceToCheck.ToString();
		return Me.GetValue<List<long>>("NpcExtender-GetAllAllies");
		
	}catch(Exception exc){
		
		return new List<long>();
		
	}
	
}