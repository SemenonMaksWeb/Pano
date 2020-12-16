using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharState
{
	private bool healthChar = true; // жив ли игрок
	private const int maxState  = 100; // максимальное значения всех показателей
	private const int maxSpeed  = 5; // максимальное значения всех показателей
    private int health;// Здоровье игрока
    private int psyche;// Психика игрока
    private int cheerfulness = 100;// бодрость игрока
    private int knowledge;// знания игрока  
	private int speed = maxSpeed; // Скорость героя

	public bool getHealthChar(){ // Вернуть Жив ли герой
		return healthChar;
	}

	public int getPsyche(){ // Вернуть Психику игрока
		return psyche;
	}
	public int getHealth(){ // Вернуть бодрость игрока
		return health;
	}
	public int getCheerfulness(){ // Вернуть бодрость игрока
		return cheerfulness;
	}
	public int getKnowledge(){ // Вернуть знания игрока  
		return knowledge;
	}
	public int getSpeed(){ // Вернуть Скорость игрока
		return speed;
	}
	public void setHealth(int Value){ // Сохранить Здоровье игрока
		health = health + Value;
		if(health <= 0){ // игрок умер
			healthChar = false;
		}
		if(health > maxState){ // У игрока больше 100% ХП
			health = maxState;
		}
	}

	public void setPsyche(int Value){ // Сохранить Психику игрока
		psyche = psyche + Value;
		if(psyche > maxState){ // У игрока больше 100% Психики
			psyche = maxState;
		}
	}
	public void setKnowledge(int Value){ // Сохранить знания игрока
		knowledge = knowledge + Value;
		if(knowledge > maxState){ // У игрока больше 100% знания
			knowledge = maxState;
		}
	}

	public void setCheerfulness(int Value){ // Сохранить бодрость игрока
		cheerfulness = cheerfulness + Value;
		if(cheerfulness > maxState){ // У игрока больше 100% бодрость
			cheerfulness = maxState;
		}
		checkSpeend();
	}
	public void checkSpeend(){ // Сохранить скорость
		if(cheerfulness > 80){
            speed = maxSpeed;
        }else if(cheerfulness > 60){
            speed = 4;
        }else if(cheerfulness > 40){
            speed = 3;
        }else if(cheerfulness > 20){
            speed = 2;
        }
        else if(cheerfulness >= 0){
            speed = 1;
        }
	}
}
