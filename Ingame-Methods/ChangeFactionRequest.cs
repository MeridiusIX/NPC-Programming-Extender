//NPC Programming Extender - ChangeFactionRequest

/*
Description:
	 - This method allows you to change the ownership of the
	 grid the PB is run from to a new NPC faction

Dependancies:
	 - NPC Programming Extender mod.
Arguments:
	string factionTag
		//The new faction tag you want to switch to.
	
*/

bool ChangeNPCFaction(string factionTag){
	
	try{
		
		Me.CustomData = factionTag;
		return Me.GetValue<bool>("NpcExtender-ChangeFactionRequest");
		
	}catch(Exception exc){
		
		return false;
		
	}

}
