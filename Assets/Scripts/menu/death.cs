using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class death : MonoBehaviour
{
	private MonoBehaviour deathMenu;
	public Char Char;
    // Start is called before the first frame update
    void Start()
    {
		deathMenu = GetComponent<MonoBehaviour>(); 
		if(Char.stateChar.getHealthChar()){
			deathMenu.gameObject.SetActive(false);
		}else{
			deathMenu.gameObject.SetActive(true);
		}
		InvokeRepeating("checkChar", 1 , 1);
    }

    // Update is called once per frame
    void Update()
    {	
		 
    }
	private void checkChar(){
		if(Char != null){
			if(!Char.stateChar.getHealthChar()){
				deathMenu.gameObject.SetActive(true);
			}
		}
	}
}
