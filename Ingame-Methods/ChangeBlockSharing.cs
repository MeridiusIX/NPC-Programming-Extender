//NPC Programming Extender - ChangeBlockSharing

/*
Description:
	 - This method will set the share mode of any terminal
	 block. Blocks can be set to shared with None, Faction, 
	 or All. It is not a good idea to try to change the 
	 share mode of any NPC Programmable Block to 'All',
	 since this would allow a player to access the Programming
	 Extender methods.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//This should be the entity Id of the block you want to change.
	
	string shareMode
		//This value can be set to "None", "Faction", or "All".
*/

bool ChangeBlockSharing(long entityId, string shareMode = "None"){
	
	try{
		
		Me.CustomData = shareMode + "\n" + entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-ChangeBlockSharing");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}