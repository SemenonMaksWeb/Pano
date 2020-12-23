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
    }

    // Update is called once per frame
    void Update()
    {
		if(Char != null){
			if(!Char.stateChar.getHealthChar() ){
				deathMenu.gameObject.SetActive(true);
			}
		}
    }
}
