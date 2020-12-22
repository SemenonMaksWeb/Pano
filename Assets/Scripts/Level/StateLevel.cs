using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateLevel
{
	private bool CheckKybikZombi = false; // Попался ли игрок зомби?
	private bool CheckZombiBoi = false; // Идет ли бой с зомби?
	private bool CheckTimeLoot = true; // Время ли ща лута?
	private bool CheckTimeZombi = false; // Время ли ща побега от зомби?
	private bool CheckExit = false; // Открыт ли выход?
	private int TimeMinuteLoot; // Время лута минут
	private int TimeSecondLoot = 0; // Счетчик лута секунды
	private int TimeMinuteZombi; // Время зомби минут
	private int TimeSecondZombi = 0; // Счетчик зомби секунды
	private string NameLevel; // Название уровня

	public int getTimeMinuteLoot(){ // Возвращает минуты лута
		return TimeMinuteLoot;
	}
	public int getTimeSecondLoot(){ // Возвращает секунды лута
		return TimeSecondLoot;
	}
	public int getTimeMinuteZombi(){ // Возвращает минуты зомби
		return TimeMinuteZombi;
	}
	public int getTimeSecondZombi(){ // Возвращает секунды зомби
		return TimeSecondZombi;
	}
	public bool getCheckTimeLoot(){// Возвращает флаг время ли сейчас лута?
		return CheckTimeLoot;
	}
	public bool getCheckTimeZombi(){// Возвращает флаг время ли сейчас зомби?
		return CheckTimeZombi;
	}
	public bool getCheckExit(){// Возвращает флаг открыт ли выход?
		return CheckExit;
	}
	public string getNameLevel(){// Возвращает Название уровня
		return NameLevel;
	}
	public bool getCheckZombiBoi(){// Возвращает флаг  Идет ли бой с зомби?
		return CheckZombiBoi;
	}
	public bool getCheckKybikZombi(){// Возвращает Попался ли игрок зомби?  
		return CheckKybikZombi;
	}
	public void setTimeMinuteLoot(int time){ // Сохранить время лута на уровне
		TimeMinuteLoot = time;
	}
	public void setTimeMinuteZombi(int time){// Сохранить время зомби на уровне
		TimeMinuteZombi = time;
	}

	public void setTimeLoot(){
		if(TimeMinuteLoot == 0 && TimeSecondLoot == 0){ // время закончилось
			CheckTimeLoot = false;		 
			CheckTimeZombi = true;
		}
		else if(TimeSecondLoot == 0){// Если секунд нету
			TimeSecondLoot = 59;
			TimeMinuteLoot = TimeMinuteLoot -1;
		}else if(TimeSecondLoot != 0){// Если секунды есть
			TimeSecondLoot =  TimeSecondLoot -1;
		}
	}
		public void setTimeZombi(){
		if(TimeMinuteZombi == 0 && TimeSecondZombi == 0){ // время закончилось
			CheckTimeLoot = false;		 
			CheckTimeZombi = true;
		}
		else if(TimeSecondZombi == 0){// Если секунд нету
			TimeSecondZombi = 59;
			TimeMinuteZombi = TimeMinuteZombi -1;
		}else if(TimeSecondZombi != 0){// Если секунды есть
			TimeSecondZombi =  TimeSecondZombi -1;
		}
	}
	public void setNameLevel(string name){ // сохранить имя уровня
		NameLevel = name;
	}
	public void setCheckZombiBoi(bool name){ // сохранить  флаг  Идет ли бой с зомби?
		CheckZombiBoi = name;
	}
	public void setCheckKybikZombi(bool name){ // сохранить флаг Попался ли игрок зомби?
		CheckKybikZombi = name;
	}
}
  
