using UnityEngine;

public class StateLevel : MonoBehaviour
{
	private bool CheckKybikZombi = false; // Попался ли игрок зомби?
	private bool CheckZombiBoi = false; // Идет ли бой с зомби?
	private bool CheckTimeLoot = true; // Время ли ща лута?
	private bool CheckTimeZombi = false; // Время ли ща побега от зомби?
	private bool CheckExit = false; // Открыт ли выход?
	private int TimeMinuteLoot; // Время лута минут
	private int TimeSecondLoot; // Счетчик лута секунды
	private int TimeMinuteZombi; // Время зомби минут
	private int TimeSecondZombi; // Счетчик зомби секунды
	private string NameLevel; // Название уровня
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
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
	public void setTimeLoot(int TimeMinute, int TimeSecond ,bool flagFalse , bool flagTrue){ // Функция таймер которая уменьшает время на 1 секунду
		if(TimeMinute == 0 && TimeSecond == 0){ // Время закончилось
			flagFalse = false;
			flagTrue = true;
		}
		else if(TimeSecond == 0){ // Если секунд нету
			TimeSecond = 59;
			TimeMinute = TimeMinute -1;
		}else if(TimeSecond != 0){// Если секунды есть
			TimeSecond =  TimeSecond -1;			
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
  
