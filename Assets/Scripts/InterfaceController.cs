using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ModelController;
namespace InterfaceController{
	public interface ISceneController                      
	{
		void LoadResources();
	}
	public interface IUserAction                           
	{
		void MoveBoat();                                   
		void Restart();                                    
		void MoveRole(RoleModel role);                                                           
	}
}
