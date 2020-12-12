using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
    public GameObject player;
    public int speed = 2;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBottom(){
        rb.velocity = new Vector3(0, 0, -speed);
    }
    public void ClickTop(){
        rb.velocity = new Vector3(0, 0, speed);
    }
    public void ClickRight(){
        // Debug.Log(transform.position);
        rb.velocity = new Vector3(speed, 0, 0);
    }
    public void ClickLeft(){
        Debug.Log(transform.position);
        rb.velocity = new Vector3(-speed, 0, 0);
    }
}