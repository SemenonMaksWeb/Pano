using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kybik : MonoBehaviour
{
	public Char Char;
	private int valueChar;
	private int valueZombi;
	private System.Random Random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
		Char.stateChar.setPsyche(-50);
        CheckMinMaxValue();
		Debug.Log(getvalueChar().ToString());
		Debug.Log(getvalueZombi().ToString());
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
		 valueChar = Random.Next(min, max);
	}
	public void RamdonZombi(int min , int max){
		 valueZombi = Random.Next(min, max);
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
			maxUser = 4;
			maxZombi = 6;
		}
		else if(psyche > 20){
			maxUser = 3;
			maxZombi = 6;
		}
	RamdonUser(1, maxUser);
	RamdonZombi(1, maxZombi);
	}

}
