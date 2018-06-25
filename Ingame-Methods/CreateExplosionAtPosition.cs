//NPC Programming Extender - CreateExplosionAtPosition

/*
Description:
	 - This method allows you to create an explosion at a
	 set of coordinates. Explosion size and damage can be
	 configured as well.
	
Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	Vector3D position
		//The coordinates of where the explosion will be created
	
	float radius
		//The explosion radius
	
	float damage
		//Damage from the explosion
*/

bool CreateExplosionAtPosition(Vector3D position, float radius = 10, float damage = 1000){
	
	try{
		
		Me.CustomData = position.ToString() + "\n" + radius.ToString() + "\n" + damage.ToString();
		return Me.GetValue<bool>("NpcExtender-CreateExplosionAtPosition");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}