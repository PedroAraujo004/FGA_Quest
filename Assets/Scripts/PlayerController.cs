using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health= 100;
    public float speed= 5.5f;
    public string PlayerName= "Pedro";
    
    private Vector2 movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(speed > 0)
    {
       float input= Input.GetAxis("Horizontal");
       float input2= Input.GetAxis("Vertical");

       movement.x= input * speed * Time.deltaTime;
       movement.y= input2 * speed * Time.deltaTime;
       
       transform.Translate(movement);
    }
    }
}
