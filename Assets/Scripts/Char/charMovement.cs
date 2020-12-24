using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement	 
{
	public int speed;
	public CharacterController CharacterController;
	public charMovement(int ValueSpeed , CharacterController ValueCharacterController){
		speed = ValueSpeed;
		CharacterController = ValueCharacterController;
	}  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickBottom(){ // Передвижение назад
        Vector3 dir = new Vector3(0, 0 , -1 * speed);
		CharacterController.Move(dir);
    }
	public void ClickTop(){// Передвижение вперед
		Vector3 dir = new Vector3(0, 0 , 1 * speed);
		CharacterController.Move(dir);
	}
	public void ClickRight(){// Передвижение вправо
		Vector3 dir = new Vector3(1 * speed, 0 , 0);
		CharacterController.Move(dir);
	}
	public void ClickLeft(){// Передвижение влево
		Vector3 dir = new Vector3(-1 * speed, 0 , 0);
		CharacterController.Move(dir);	 
	}
}