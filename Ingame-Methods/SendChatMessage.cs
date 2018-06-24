//NPC Extender - SendChatMessage

/*
Description:
	 - This method allows NPCs to send messages through the
	 ingame chat system. The message will reach any player
	 within the range of the NPC's active antenna. Audio can
	 also be attached to these messages as well.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string message
		//The chat message you want to display.
		
	string author
		//The name of the message sender/author.
		
	string audioClip
		//The SubtypeId of the audio clip you want to play.
*/

bool SendChatMessage(string message, string author, string audioClip = ""){
	
	double broadcastDistance = 0;
	var antennaList = new List<IMyRadioAntenna>();
	GridTerminalSystem.GetBlocksOfType<IMyRadioAntenna>(antennaList);
	
	foreach(var antenna in antennaList){
		
		if(antenna.IsFunctional == false || antenna.Enabled == false || antenna.EnableBroadcasting == false){
			
			continue;
			
		}
		
		var antennaRange = (double)antenna.Radius;
		
		if(antennaRange > broadcastDistance){
			
			broadcastDistance = antennaRange;
			
		}
	
	}
	
	if(broadcastDistance == 0){
		
		return false;
		
	}
	
	try{
		
		string sendData = message + "\n" + author + "\n" + broadcastDistance.ToString() + "\n" + audioClip;
		Me.CustomData = sendData;
		return Me.GetValue<bool>("NpcExtender-ChatToPlayers");
		
	}catch(Exception exc){
		
		return false;
		
	}

}
