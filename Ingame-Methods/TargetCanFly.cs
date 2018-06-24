//NPC Programming Extender - TargetCanFly

/*
Description:
	 - This method will check if a grid (identified via
	 entity ID) is capable of proper flight. It will
	 check for thrust in all directions, gyros, power,
	 and a functional ship controller. If any of these
	 requirements are not met, the method returns false.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//This should be the entity Id of the grid you want to check.
*/

bool TargetCanFly(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-TargetCanFly");
		
	}catch(Exception exc){
		
		return false;
		
	}
	
}