//NPC Programming Extender - IsPositionInNaturalGravity

/*
Description:
	 - This method will identify if the provided coordinates are
   within a natural gravity well of a planet or moon.
Dependancies:
	 - NPC Programming Extender mod.
Arguments:
	Vector3D checkCoords
		//The coordinates you want to check for the closest
		//planet near.
*/

bool IsPositionInNaturalGravity(Vector3D checkCoords){
	
	try{
		
		Me.CustomData = checkCoords.ToString();
		return Me.GetValue<bool>("NpcExtender-IsPositionInNaturalGravity");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}
