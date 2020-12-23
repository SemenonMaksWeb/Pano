using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
	public CharState stateChar;
	public charMovement charMovement;
	private Rigidbody rb; // Твердое тело
    // Start is called before the first frame update
	void Start(){

	}
    void Awake()
    {
		rb = GetComponent<Rigidbody>();
		stateChar = new CharState();
		//charMovement = new charMovement(stateChar.getSpeed(), rb);
		//Debug.Log(this);   
    }

    // Update is called once per frame
    void Update()
    {
   
    }
	public void ClickBottom(){
		charMovement.ClickBottom();
	}
	public void ClickTop(){
		charMovement.ClickTop();
	}
	public void ClickRight(){
		charMovement.ClickRight();
	}
	public void ClickLeft(){
		charMovement.ClickLeft();
	}
}
