using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
    public GameObject camera; 
    public int speed = 2;
    public static float setCamera;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(transform.position.x , 35, transform.position.z);
    }

    public void ClickBottom(){
        rb.velocity = new Vector3(0, 0, -speed);
        
    }
    public void ClickTop(){
        rb.velocity = new Vector3(0, 0, speed);
    }
    public void ClickRight(){
        rb.velocity = new Vector3(speed, 0, 0);
    }
    public void ClickLeft(){
        rb.velocity = new Vector3(-speed, 0, 0);
    }
}