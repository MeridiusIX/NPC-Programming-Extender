//NPC Programming Extender - TargetIsStatic

/*
Description:
	 - This method identifies if the target grid is static (station).

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The entity Id of the grid you want to check.
*/

bool TargetIsStatic(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-TargetIsStatic");
		
	}catch(Exception exc){
		
		return false;
		
	}

}