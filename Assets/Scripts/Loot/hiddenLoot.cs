using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenLoot : MonoBehaviour
{
	public Level Level;
	private MonoBehaviour loot;
    // Start is called before the first frame update
    void Start()
    {
        loot = GetComponent<MonoBehaviour>(); 
    }

    // Update is called once per frame
    void Update()
    {
    if(Level.LevelState.getCheckTimeLoot() == false){
			loot.gameObject.SetActive(false);
		} 
    }
}
