//NPC Programming Extender - CheckIfNPC

/*
Description:
	 - This method will check the ownership of the grid
	 to see if it is owned by any of the valid NPC factions.
	 You can also specify a faction tag in the method
	 argument to check only that faction as well.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string faction
		//The faction tag you want to check against.
		//Leave blank to check all NPC factions.
*/

bool CheckIfNPC(string faction = ""){
	
	try{
		
		if(faction == ""){
			
			return Me.GetValue<bool>("NpcExtender-IsOwnedByNPC");
			
		}else{
			
			Me.CustomData = faction;
			return Me.GetValue<bool>("NpcExtender-IsOwnedByFaction");
			
		}
		
	}catch(Exception exc){
		
		return false;
		
	}

}