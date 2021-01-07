using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonSpawn : MonoBehaviour
{
	private System.Random Random = new System.Random();
	public MonoBehaviour loot;
	private int check;
    void Start()
    {
		//loot = GetComponent<MonoBehaviour>(); 
        check = Random.Next(0,2); 
		GetLoot(check);
    }
	private void GetLoot(int check){
		if(check == 0){
			loot.gameObject.SetActive(false);
		}else if(check > 0){
			loot.gameObject.SetActive(true);
		}
	}
}
