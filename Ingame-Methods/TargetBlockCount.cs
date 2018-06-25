//NPC Programming Extender - TargetBlockCount

/*
Description:
	 - This method count the number of blocks on a specified grid.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The entity Id of the grid you want to get the block count from.
*/

int TargetBlockCount(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<int>("NpcExtender-TargetBlockCount");
		
	}catch(Exception exc){
		
		return 0;
		
	}

}