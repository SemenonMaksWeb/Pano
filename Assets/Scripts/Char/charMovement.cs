using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement: MonoBehaviour	 
{
	public Char Char;  
    void Start()
    {
    }
    void Update()
    {
       		
    }
    public void ClickBottom(){ // Передвижение назад
		if(Char.stateChar.getHealthChar()){
		    Vector3 Move = new Vector3(0, 0 , -0.05f * Char.stateChar.getSpeed());
			Quaternion target = Quaternion.Euler(0, -180, 0);
			Char.CharacterController.transform.rotation = target;
			Char.CharacterController.Move(Move);
		}
    }
	public void ClickTop(){// Передвижение вперед
		if(Char.stateChar.getHealthChar()){
			Vector3 dir = new Vector3(0, 0 , 0.05f * Char.stateChar.getSpeed());
			Quaternion target = Quaternion.Euler(0, 0, 0);
			Char.CharacterController.transform.rotation = target;
			Char.CharacterController.Move(dir);
		}
	}
	public void ClickRight(){// Передвижение вправо
		if(Char.stateChar.getHealthChar()){
			Vector3 dir = new Vector3(0.05f * Char.stateChar.getSpeed(), 0 , 0);
			Quaternion target = Quaternion.Euler(0, 90, 0);
			Char.CharacterController.transform.rotation = target;
			Char.CharacterController.Move(dir);
		}
	}
	public void ClickLeft(){// Передвижение влево
		if(Char.stateChar.getHealthChar()){
			Vector3 dir = new Vector3(-0.05f * Char.stateChar.getSpeed(), 0 , 0);
			Quaternion target = Quaternion.Euler(0, -90, 0);
			Char.CharacterController.transform.rotation = target;
			Char.CharacterController.Move(dir);	
		} 
	}
}