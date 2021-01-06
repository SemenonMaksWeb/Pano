using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class spawnStatis : MonoBehaviour, IPointerClickHandler
{
	public TriggerGetLoot TriggerGetLoot;
	public Char Char;
	public Level Level;
	private MonoBehaviour loot;
	private System.Random Random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        loot = GetComponent<MonoBehaviour>(); 
		int check = Random.Next(0,2); 
		if(check == 0){
			loot.gameObject.SetActive(false);
		}else if(check > 0){
			loot.gameObject.SetActive(true);
		}
		Debug.Log(TriggerGetLoot.getTrigger());
    }
	public void OnPointerClick(PointerEventData pointerEventData){
		if(TriggerGetLoot.getTrigger()){
			Char.stateChar.setCheerfulness(20);
			loot.gameObject.SetActive(false);
		}
	}
    // Update is called once per frame
    void Update()
    {
		if(Level.LevelState.getCheckTimeLoot() == false){
			loot.gameObject.SetActive(false);
		}
      //  Debug.Log(TriggerGetLoot.getTrigger());
    }
}
