//NPC Extender - GetTrackedEntityPosition

/*
Description:
	 - This method will get the position of a grid or block by
	 providing its entity Id.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The grid or block entityId you want to get the position of.
*/

Vector3D GetTrackedEntityPosition(long entityId){
	
	try{
		
		Me.CustomData = entityId.ToString();
		return Me.GetValue<Vector3D>("NpcExtender-TrackEntity");
		
	}catch(Exception exc){
		
		return new Vector3D(0,0,0);
		
	}

}