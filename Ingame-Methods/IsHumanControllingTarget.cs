//NPC Programming Extender - IsHumanControllingTarget

/*
Description:
	 - This method will identify if a grid is being controlled by a human player.
Dependancies:
	 - NPC Programming Extender mod.
Arguments:
	long entityId
		//The entity id of the grid you want to check.
*/

bool IsHumanControllingTarget(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-IsHumanControllingTarget");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}
