//NPC Extender - GridSetDestructable

/*
Description:
	 - This method allows you to set whether of not a grid is
	 destructable.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The grid you want to set destructability for.
		
	bool setMode
		//true for Destructable, false for Indestructable
*/

bool GridSetDestructable(long entityId, bool setMode = true){
	
	try{
		
		Me.CustomData = setMode.ToString() + "\n" + entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-GridSetDestructable");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}