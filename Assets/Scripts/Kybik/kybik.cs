using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kybik : MonoBehaviour
{
	public Char Char;
	private int valueChar;
	private int valueZombi;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public int getvalueChar(){ // Вернуть значение кубика игрока
		return valueChar;
	}
	public int getvalueZombi(){ // Вернуть значение кубика зомби  
		return valueZombi;
	}
	public void RamdonUser(int min , int max ){
		
	}
	public void RamdonZombi(int min , int max){
		
	}
	public void CheckMinMaxValue(){
		int maxUser = 6;
		int maxZombi = 6;
		int psyche = Char.stateChar.getPsyche();
		if(psyche > 80){
			maxUser = 6;
			maxZombi = 4;
		}
		else if(psyche > 60){
			maxUser = 5;
			maxZombi = 5;
		}
		else if(psyche > 40){
			maxUser = 3;
			maxZombi = 6;
		}
		else if(psyche > 20){
			maxUser = 2;
			maxZombi = 6;
		}
	RamdonUser(1, maxUser);
	RamdonUser(1, maxZombi);
	}

}
