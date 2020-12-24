using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
	public CharState stateChar;
	public charMovement charMovement;
	private CharacterController CharacterController; // Твердое тело
    // Start is called before the first frame update
	void Start(){

	}
    void Awake()
    {
		CharacterController = GetComponent<CharacterController>();
		stateChar = new CharState();
		charMovement = new charMovement(stateChar.getSpeed(), CharacterController);
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
