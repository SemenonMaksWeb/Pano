using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class spawn : MonoBehaviour
{
	private List<int> indexSet = new List<int>();
	private System.Random Random = new System.Random();
	public GameObject Loot; // Префаб вашего Enemy
	public int CountLoot; // Количество врагов, которое вы хотите заспавнить
	public Vector3 [] RandomLoot; 
	public Vector3 [] RecordingLoot; 

    // Start is called before the first frame update
    void Start()
    {
		Debug.Log(RandomLoot.Length);
		for (int i = 0; i < CountLoot; i++) {
			CheckRamdom();
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private int RandomLootGet(){
		return Random.Next(0, RandomLoot.Length);
	}

	private void CheckRamdom(){
		int index =  RandomLootGet();
		int check = indexSet.IndexOf(index);
		if(check == -1){
			indexSet.Add(index);
			CreateLoot(index);
		}else{
			CheckRamdom();
		}
	}

	private void CreateLoot(int index){	
		Instantiate(Loot, RandomLoot[index], Quaternion.identity);
	}
}
