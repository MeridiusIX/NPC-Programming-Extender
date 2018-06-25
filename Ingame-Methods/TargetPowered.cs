//NPC Programming Extender - TargetPowered

/*
Description:
	 - This method identifies if the target grid is currently powered.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The entity Id of the grid you want to check.
*/

bool TargetPowered(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-TargetPowered");
		
	}catch(Exception exc){
		
		return false;
		
	}

}