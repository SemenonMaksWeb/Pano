using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCheerfulness : MonoBehaviour
{
	public Char Char;
	public Level Level;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("TimeCheerfulnessDelete", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void TimeCheerfulnessDelete(){
		if(!Level.LevelState.getCheckKybikZombi() && !Level.LevelState.getCheckZombiBoi()){
				Char.stateChar.setCheerfulness(-1);
		}
	} 
}
