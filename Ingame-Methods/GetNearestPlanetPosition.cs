


Vector3D GetNearestPlanetPosition(IMyTerminalBlock sourceBlock){
			
			Vector3D checkCoords = new Vector3D(0,0,0);
			
			if(Vector3D.TryParse(sourceBlock.CustomData, out checkCoords) == false){
				
				return checkCoords;
				
			}
			
			var planet = MyGamePruningStructure.GetClosestPlanet(checkCoords);
			
			if(planet == null){
				
				return checkCoords;
				
			}
			
			var planetEntity = planet as IMyEntity;
			return planetEntity.GetPosition();
			
		}
