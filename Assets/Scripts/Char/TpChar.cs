using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpChar : MonoBehaviour
{
	private MonoBehaviour tp;
	public Level Level;
	public MonoBehaviour Char;
	public Vector3 Vector3Char; 
    // Start is called before the first frame update
    void Start()
    {
        tp = GetComponent<MonoBehaviour>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Level.LevelState.getCheckTimeZombi()){
			Char.transform.position = Vector3Char; 
			tp.gameObject.SetActive(false);
		}
    }
}
