//NPC Extender - CreateParticleEffect

/*
Description:
	 - This method allows you to play a Particle Effect
	 at a fixed position, or at the position of a provided
	 entity.

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string effectName
		//The SubtypeId of the Particle Effect you want to play
	
	Vector3D effectCoords
		//The fixed coords of where you want the effect to play
	
	long effectEntity
		//The entity you want the effect to play at. This overrides
		//effectCoords if both are provided
*/

bool CreateParticleEffect(string effectName, Vector3D effectCoords, long effectEntityId = 0){
	
	Me.CustomData = "ParticleEffectRequest\n" + effectName + "\n";
	
	if(effectEntityId != 0){
		
		Me.CustomData += effectEntityId.ToString();
		
	}else{
		
		Me.CustomData += effectCoords.ToString();
		
	}
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-PlayParticleEffect");
		
	}catch(Exception exc){
		
		return false;
		
	}
	
}	