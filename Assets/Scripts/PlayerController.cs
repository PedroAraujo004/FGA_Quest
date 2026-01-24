using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 100;
    public float speed = 5.5f;
    public string PlayerName = "Pedro";
    
    // <--- 1. NÃO ESQUEÇA DE ARRASTAR O BONECO PARA CA NO INSPECTOR
    public Animator animator; 

    private Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        if(speed > 0)
        {
            // O seu usa GetAxis (com inércia/suavização)
            float input = Input.GetAxis("Horizontal");
            float input2 = Input.GetAxis("Vertical");

            // Lógica de Movimento (Mantive a sua)
            movement.x = input * speed * Time.deltaTime;
            movement.y = input2 * speed * Time.deltaTime;
            
            transform.Translate(movement);

            // <--- 2. LÓGICA DA ANIMAÇÃO ADICIONADA AQUI
            // Verificamos se "input" ou "input2" são diferentes de zero (se tem alguém apertando botão)
            if (input != 0 || input2 != 0)
            {
                animator.SetFloat("MoveX", input);
                animator.SetFloat("MoveY", input2);
                
                // Opcional: Avisar o animator que estamos andando (se tiver transição Idle/Walk)
                animator.SetBool("IsMoving", true);
            }
            else
            {
                // Opcional: Avisar que parou
                animator.SetBool("IsMoving", false);
            }
        }
    }
}