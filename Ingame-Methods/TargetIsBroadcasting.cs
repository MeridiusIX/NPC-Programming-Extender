//NPC Programming Extender - TargetIsBroadcasting

/*
Description:
	 - This method will check a provided grid entity Id to
	 see if it has an active antenna or beacon that is currently
	 broadcasting in range of the NPC.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	long entityId
		//The entity Id of the grid you want to check.
		
	bool checkAntennas
		//If true, the method will check antenna blocks.
		
	bool checkBeacons
		//If true, the method will check beacon blocks.
*/

bool TargetIsBroadcasting(long entityId, bool checkAntennas = true, bool checkBeacons = true){
	
	try{
		
		Me.CustomData = entityId.ToString() + "\n" + checkAntennas.ToString() + "\n" + checkBeacons.ToString();
		return Me.GetValue<bool>("NpcExtender-TargetIsBroadcasting");
		
	}catch(Exception exc){
		
		return false;
		
	}

}