using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum  TypestateChar{
	health,
	psyche,
	knowledge,
	cheerfulness
}

public class LootEffect : MonoBehaviour, IPointerClickHandler
{
	public TypestateChar TypestateChar;
	public int value;
	public TriggerLoot TriggerLoot;
	public Char Char;
	private MonoBehaviour loot;

    void Start()
    {
        loot = GetComponent<MonoBehaviour>(); 
    }

	public void OnPointerClick(PointerEventData pointerEventData){
		if(TriggerLoot.getTrigger()){
			checkStateChar();
			loot.gameObject.SetActive(false);
		}
	}

	private void checkStateChar(){
		if(TypestateChar == TypestateChar.cheerfulness){
			Char.stateChar.setCheerfulness(value);
		}else if(TypestateChar == TypestateChar.health){
			Char.stateChar.setHealth(value);
		}
		else if(TypestateChar == TypestateChar.psyche){
			Char.stateChar.setPsyche(value);
		}
		else if(TypestateChar == TypestateChar.knowledge){
			Char.stateChar.setKnowledge(value);
		}
	}
}
