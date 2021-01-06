using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
	public int TimeLootLevel;
	public int TimeZombiLevel; 	
	public StateLevel LevelState;
    void Start(){
		
    }
    void Update()
    {
    }
	void Awake(){
		LevelState = new StateLevel();
		LevelState.setTimeMinuteLoot(TimeLootLevel);
		LevelState.setTimeMinuteZombi(TimeZombiLevel);
	}
}
