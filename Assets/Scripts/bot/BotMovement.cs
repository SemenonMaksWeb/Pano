using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BotMovement: MonoBehaviour
{
    GameObject player;
    public float speed;
 
    void Start()
    {
         player = GameObject.FindWithTag("Player");
    }
 
    void Update()
    {
		Vector3 pos = transform.position;
		if(
			player.transform.position.x > transform.position.x && 
			player.transform.position.x  - transform.position.x > 1.3
		){
			pos.x += speed * Time.deltaTime;
		}
		if(
		player.transform.position.x < transform.position.x &&
		transform.position.x - player.transform.position.x > 1.3
		){
			pos.x -= speed * Time.deltaTime;
		}

		if(player.transform.position.z > transform.position.z && 
		player.transform.position.z  - transform.position.z > 0.1){
			pos.z += speed * Time.deltaTime;
		}
		if(player.transform.position.z < transform.position.z && 
		transform.position.z - player.transform.position.z > 0.1
		){
			pos.z -= speed * Time.deltaTime;
		}
		transform.position = pos;
    }
}