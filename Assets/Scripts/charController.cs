using System.Collections;
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

    public GameObject textCmert;
    public bool healthChar = true; // жив ли игрок
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

    void FixedUpdate()
    {
        sliderKnowledge.value = knowledge;
        sliderCheerfulness.value = cheerfulness;
        sliderPsyche.value = psyche;
        sliderHealth.value = health;
        camera.transform.position = new Vector3(transform.position.x , 35, transform.position.z); // Передвижение камеры за игроком
    }
    void Update(){
        
    }
    public void cheerfulnessMinusTime(){ // Обнимание бодрости с временем
        if(cheerfulness > 0){
            cheerfulness = cheerfulness - 2;
            SetSpeed();
        }
    }
    public void healthMinus(int yron){ // Получение урона
        health = health - yron;
        CheckHealth();
    }
    public void CheckHealth(){ // Проверка здоровья
        if(health <= 0){
            Instantiate(textCmert);
        }
    }
    public void SetSpeed(){ // Изменения скорости взависимости от бодрости
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
 
}