 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 100;
    public float speed = 5.5f;
    public string PlayerName = "Pedro";

    List <string> backpack= new List <string> ();
    
    public Animator animator; 

    private Vector2 movement;

    void Start()
    {
        backpack.Add("espada");
        backpack.Add("poção");

        if (animator == null)
            animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
            float input = Input.GetAxis("Horizontal");
            float input2 = Input.GetAxis("Vertical");

            movement.x = input * speed * Time.deltaTime;
            movement.y = input2 * speed * Time.deltaTime;
            
            transform.Translate(movement);

            if (input != 0 || input2 != 0)
            {
                animator.SetFloat("MoveX", input);
                animator.SetFloat("MoveY", input2);
                
                animator.SetBool("IsMoving", true);
            }
            else
            {
                animator.SetBool("IsMoving", false);
            } 
    }

    public void TakeDamage(int amount)
    {
        health= health - amount;
        Debug.Log("Vida atual: " + health);
    }
}