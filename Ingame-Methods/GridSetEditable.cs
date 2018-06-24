//NPC Extender - GridSetEditable

/*
Description:
	 - This method allows you to set whether of not a grid is
	 editable.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The grid you want to set editable mode for.
		
	bool setMode
		//true for Editable, false for Uneditable
*/

bool GridSetEditable(long entityId, bool setMode = true){
	
	try{
		
		Me.CustomData = setMode.ToString() + "\n" + entityId.ToString();
		return Me.GetValue<bool>("NpcExtender-GridSetEditable");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}
