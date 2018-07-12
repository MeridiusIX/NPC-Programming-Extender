//NPC Extender - BroadcastNotification

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

bool BroadcastNotification(string message, int duration, string fontColor, double broadcastDistance = 15000, string audioClip = ""){
	
	if(broadcastDistance == 0 || message == "" || duration == 0){
		
		return false;
		
	}
	
	try{
		
		string sendData = message + "\n" + duration.ToString() + "\n" + fontColor + "\n" + broadcastDistance.ToString() + "\n" + audioClip;
		Me.CustomData = sendData;
		return Me.GetValue<bool>("NpcExtender-BroadcastNotification");
		
	}catch(Exception exc){
		
		return false;
		
	}
	
}
