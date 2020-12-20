using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class TimeLoot: MonoBehaviour
{
	private Text text; // Надпись времени
	public Level Level;
    void Start()
    {
	    text = GetComponent<Text>();
		StartText();
    }
	private void StartText(){
		string name = "";
		string minute = "";
		string second = "";
		if(Level.LevelState.getCheckTimeLoot()){ // Время лута
			name = "Время лута:";
			minute = Level.LevelState.getTimeMinuteLoot().ToString();
			second = Level.LevelState.getTimeSecondLoot().ToString();
		}
		else if(Level.LevelState.getCheckTimeZombi()){// Время выживания
			name = "Время выживания:";
			minute = Level.LevelState.getTimeMinuteZombi().ToString();
			second = Level.LevelState.getTimeSecondZombi().ToString();
		}
		if(second.Length != 2){ // фикс 1 цифры когда секунд меньше 1значного-символа
			second = "0" + second;
		}
		text.text = name + " " +  minute + ":" + second;
	}
	 void Example() {
		if(Level.LevelState.getCheckTimeLoot() ){// Время лута
		CancelInvoke();
		//Invoke(Level.LevelState.setTimeAll(
		//Level.LevelState.getCheckTimeLoot(),
		//Level.LevelState.getTimeSecondLoot(),
		//);
		}
	 }
}
