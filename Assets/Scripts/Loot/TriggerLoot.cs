using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerLoot : MonoBehaviour
{
	private bool Trigger = false;	
	//public MonoBehaviour TriggerLoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
   
    }
	void OnTriggerEnter(Collider col){
		Trigger  = true;
	}
	void OnTriggerExit(Collider col){
		Trigger  = false;
	}
	public bool getTrigger(){
		return Trigger;
	}
}
