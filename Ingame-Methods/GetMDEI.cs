//NPC Programming Extender - GetMDEI

/*
Description:
	 - This method will retrieve the MyDetectedEntityInfo
	 for a specified grid

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The entity Id of the grid you want to retrieve the MyDetectedEntityInfo for.
*/

MyDetectedEntityInfo GetMDEI(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<MyDetectedEntityInfo>("NpcExtender-GetDetectedEntityInfo");
		
	}catch(Exception exc){
		
		Echo("Hard fail NpcExtender-GetDetectedEntityInfo");
		return new MyDetectedEntityInfo();
		
	}
	
}