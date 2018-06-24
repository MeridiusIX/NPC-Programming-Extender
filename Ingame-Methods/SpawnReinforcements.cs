//NPC Extender - SpawnReinforcements

/*
Description:
	 - This method allows NPCs to spawn prefabs or spawngroups
	 as reinforcements, or even as enemy encounters.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string spawnType
		//Should either be "Prefab" or "SpawnGroup", depending on
		//what you want to spawn.
		
	string spawnName
		//The SubtypeId of the Prefab or SpawnGroup.
		
	string spawnFaction
		//the faction tag you want to assign ownership of the
		//spawned grid to.
		
	bool mustSpawnAll
		//If true, the spawner must be able to spawn all grids
		//specified in the Prefab/SpawnGroup, otherwise the method
		//will return false and nothing will spawn.
	
	Vector3D spawnCoords
		//The coordinates the Prefab/SpawnGroup will appear at.
		
	Vector3D forwardDirection
		//The forward directional vector used for spawning.
		
	Vector3D upDirection
		//The up directional vector used for spawning.
		
	Vector3D spawnVelocity
		//The initial velocity the grids will have on spawn.
*/

bool SpawnReinforcements(string spawnType, string spawnName, string spawnFaction, bool mustSpawnAll, Vector3D spawnCoords, Vector3D forwardDirection, Vector3D upDirection, Vector3D spawnVelocity){
	
	string spawnData = spawnType + "\n";
	spawnData += spawnName + "\n";
	spawnData += spawnFaction + "\n";
	spawnData += mustSpawnAll.ToString() + "\n";
	spawnData += spawnCoords.ToString() + "\n";
	spawnData += forwardDirection.ToString() + "\n";
	spawnData += upDirection.ToString() + "\n";
	spawnData += spawnVelocity.ToString();
	
	try{
		
		Me.CustomData = spawnData;
		return Me.GetValue<bool>("NpcExtender-SpawnReinforcements");
		
	}catch(Exception exc){
		
		return false;
		
	}
	
}
