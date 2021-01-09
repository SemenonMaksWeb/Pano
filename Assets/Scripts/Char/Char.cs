using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char: MonoBehaviour
{
	public CharState stateChar;
	public CharacterController CharacterController; // Твердое тело
    // Start is called before the first frame update
	void Start(){

	}
    void Awake()
    {
		CharacterController = GetComponent<CharacterController>();
		stateChar = new CharState(); 
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
