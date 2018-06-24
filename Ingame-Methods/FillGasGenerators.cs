//NPC Extender - FillGasGenerators

/*
Description:
	 - This method will automatically replenish gas generators
	 on the grid with Ice when called. This is useful for ships
	 without hydrogen tanks

Dependancies:
	 - NPC Programming Extender mod.

Arguments:
	 - None
*/

bool FillGasGenerators(){
	
	try{
		
		return Me.GetValue<bool>("NpcExtender-IceRefill");
		
	}catch(Exception exc){
		
		return false;
		
	}
			
}