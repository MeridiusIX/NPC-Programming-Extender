//NPC Programming Extender - CreateItemInInventory

/*
Description:
	 - This method allows you to create and add any inventory
	 item to a block inventory. You will need to provide the
	 item TypeId (acceptable types found below), the item 
	 SubtypeId

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	string type
		//The new faction tag you want to switch to.
	 
	string subtype
		//The new faction tag you want to switch to.
	
	float amount
		//The new faction tag you want to switch to.
	
	long blockEntityId
		//The new faction tag you want to switch to.
*/

/*
	Valid ObjectBuilders for use in "type" argument:
	
	MyObjectBuilder_Ore
	MyObjectBuilder_Ingot
	MyObjectBuilder_Component
	MyObjectBuilder_AmmoMagazine
	MyObjectBuilder_PhysicalGunObject
	MyObjectBuilder_OxygenContainerObject
	MyObjectBuilder_GasContainerObject
	
*/

bool CreateItemInInventory(string type, string subtype, float amount, long blockEntityId){

	Me.CustomData = type + "\n" + subtype + "\n" + amount.ToString() + "\n" + blockEntityId.ToString();
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-CreateItemInInventory");
		
	}catch(Exception exc){
		
		return false;
		
	}
	
}