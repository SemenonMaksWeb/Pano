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
		TimerAll();
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
		else if(Level.LevelState.getCheckExit()){
			text.text = "Время искать выход!";
			return;
		}
		if(second.Length != 2){ // фикс 1 цифры когда секунд меньше 1значного-символа
			second = "0" + second;
		}
		text.text = name + " " +  minute + ":" + second;
	}
	private void TimerAll() {
		if(Level.LevelState.getCheckTimeLoot() ){// Время лута
		InvokeRepeating ("LootTime", 1, 1);
		}
		else if(Level.LevelState.getCheckTimeZombi()){// Время Зомби
		InvokeRepeating ("ZombiTime", 1, 1);
		}
	 }
	 void LootTime(){ // Время лута
	 	Level.LevelState.setTimeLoot();
		StartText();
		if(!Level.LevelState.getCheckTimeLoot()){
			CancelInvoke("LootTime");
			InvokeRepeating ("ZombiTime", 1, 1);
		}
	 }
	 void ZombiTime(){ // Время Зомби
		Level.LevelState.setTimeZombi();
		StartText();
		if(!Level.LevelState.getCheckTimeZombi()){
			CancelInvoke("ZombiTime");
		}
	 }
}
