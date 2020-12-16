using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement	 
{
	public int speed;
	public Rigidbody rb;
	public charMovement(int Valuespeed , Rigidbody Valuerb){
		speed = Valuespeed;
		rb = Valuerb;
	}  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickBottom(){ // Передвижение назад
        rb.velocity = new Vector3(0, 0, -speed);    
    }
	public void ClickTop(){// Передвижение вперед
		rb.velocity = new Vector3(0, 0, speed);
	}
	public void ClickRight(){// Передвижение вправо
		rb.velocity = new Vector3(speed, 0, 0);
	}
	public void ClickLeft(){// Передвижение влево
		rb.velocity = new Vector3(-speed, 0, 0);
	}
}