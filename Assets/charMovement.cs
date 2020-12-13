using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace charMovement{
    public class charMovement: MonoBehaviour
{
    private Rigidbody rb; // Твердое тело
    public int speed = 2; // Скорость героя 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

}