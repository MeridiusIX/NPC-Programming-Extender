//NPC Extender - BroadcastNotification

/*
Description:
	 - This method allows NPCs to send messages through the
	 ingame notification system. The message will reach any player
	 player within the specified range provided.
Dependancies:
	 - NPC Programming Extender mod.
Arguments:
	string message
		//The notification message you want to display.
		
	int duration
		//The duration the notification will remain on screen
		//This is measured in milliseconds.
		
	string fontColor
		//The color of the notification font. Can be Green, Red, White
		
	double broadcastDistance
		//Any player within the specified distance from the drone will
		//receive the notification.
		
	string audioClip
		//If provided, the notification will also player a sound clip.
		//The argument should be the SubtypeId of the audio definition.
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
