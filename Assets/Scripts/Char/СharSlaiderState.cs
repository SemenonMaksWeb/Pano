using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class СharSlaiderState : MonoBehaviour{
	private Slider slaider;
	public Char Char;
	    // Start is called before the first frame update
    void Start()
    {
		slaider = GetComponent<Slider>();
 
    }

    // Update is called once per frame
    void Update()
    {
		SetValue();
    }
	private void SetValue(){
		if(Char != null){
			if(this.name == "СлайдерЗдоровья"){
				slaider.value = Char.stateChar.getHealth();
			}
			else if(this.name == "СлайдерЗнании"){
				slaider.value = Char.stateChar.getKnowledge();
			}
			else if(this.name == "СлайдерБодрости"){
				slaider.value = Char.stateChar.getCheerfulness();
			}
			else if(this.name == "СлайдерПсихики"){
				slaider.value = Char.stateChar.getPsyche();
			}
		}
		 
	} 
}
