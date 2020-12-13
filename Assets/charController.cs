﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class charController: MonoBehaviour
{
    // Передаваемые значение
    public GameObject camera;
    public Slider sliderHealth;
    public Slider sliderPsyche;
    public Slider sliderCheerfulness;
    public Slider sliderKnowledge;

    public  int maxAll  = 100; // максимальное значения всех показателей
    public  int health;// Здоровье игрока
    public  int psyche;// Психика игрока
    public  int cheerfulness;// бодрость игрока
    public  int knowledge;// знания игрока   
    public int speed = 5; // Скорость героя
    private Rigidbody rb; // Твердое тело
    void Start()
    {
        health = 100;  
        psyche = 100;  
        cheerfulness = 100; 
        knowledge = 0;  
        rb = GetComponent<Rigidbody>();
        InvokeRepeating ("cheerfulnessMinusTime", 5, 10F);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sliderKnowledge.value = knowledge;
        sliderCheerfulness.value = cheerfulness;
        sliderPsyche.value = psyche;
        sliderHealth.value = health;
        camera.transform.position = new Vector3(transform.position.x , 35, transform.position.z); // Передвижение камеры за игроком
    }
    public void cheerfulnessMinusTime(){
        if(cheerfulness > 0){
            cheerfulness = cheerfulness - 2;
            SetSpeed();
        }
    }
    public void SetSpeed(){
        if(cheerfulness > 80){
            speed = 5;
        }else if(cheerfulness > 60){
            speed = 4;
        }else if(cheerfulness > 40){
            speed = 3;
        }else if(cheerfulness > 20){
            speed = 2;
        }
        else if(cheerfulness >= 0){
            speed = 1;
        }
    }
    public void ClickBottom(){ // Передвижение назад
        rb.velocity = new Vector3(0, 0, -speed);
        
    }
    public void ClickTop(){// Передвижение вперед
        rb.velocity = new Vector3(0, 0, speed);
    }
    public void ClickRight(){// Передвижение вправо
        rb.velocity = new Vector3(speed, 0, 0);
    }
    public void ClickLeft(){// Передвижение влево
        rb.velocity = new Vector3(-speed, 0, 0);
    }
}