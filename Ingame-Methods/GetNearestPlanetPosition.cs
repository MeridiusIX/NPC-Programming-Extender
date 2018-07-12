//NPC Programming Extender - GetNearestPlanetPosition

/*
Description:
	 - This method will get the coordinates of the nearest planet
	 to the provided coordinates.
Dependancies:
	 - NPC Programming Extender mod.
Arguments:
	Vector3D checkCoords
		//The coordinates you want to check for the closest
		//planet near.
*/

Vector3D GetNearestPlanetPosition(Vector3D checkCoords){

	try{
		
		Me.CustomData = checkCoords.ToString();
		return Me.GetValue<Vector3D>("NpcExtender-GetNearestPlanetPosition");
		
	}catch(Exception exc){
		
		return Vector3D.Zero;
		
	}

}
