using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CametaChar: MonoBehaviour
{
	public MonoBehaviour Char;
	private const int positionY = 35;
    void Start()
    {
        
    }

    void Update()
    {
         transform.position = new Vector3(Char.transform.position.x , 35, Char.transform.position.z); // Передвижение камеры за игроком
    }
}
