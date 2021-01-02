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
        Vector3 Move = new Vector3(0, 0 , -0.05f * speed);
		Quaternion target = Quaternion.Euler(0, -180, 0);
		CharacterController.transform.rotation = target;
		CharacterController.Move(Move);
    }
	public void ClickTop(){// Передвижение вперед
		Vector3 dir = new Vector3(0, 0 , 0.05f * speed);
		Quaternion target = Quaternion.Euler(0, 0, 0);
		CharacterController.transform.rotation = target;
		CharacterController.Move(dir);
	}
	public void ClickRight(){// Передвижение вправо
		Vector3 dir = new Vector3(0.05f * speed, 0 , 0);
		Quaternion target = Quaternion.Euler(0, 90, 0);
		CharacterController.transform.rotation = target;
		CharacterController.Move(dir);
	}
	public void ClickLeft(){// Передвижение влево
		Vector3 dir = new Vector3(-0.05f * speed, 0 , 0);
		Quaternion target = Quaternion.Euler(0, -90, 0);
		CharacterController.transform.rotation = target;
		CharacterController.Move(dir);	 
	}
}