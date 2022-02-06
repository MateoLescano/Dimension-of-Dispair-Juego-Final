using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    public float forceJump;//fuerza de salto

    [SerializeField] private float speed;// velocidad de movimiento

    private Vector2 movement = Vector2.zero;//movimiento izquierda-derecha || izquierda x<0 y derecha x>0

    bool jump;//habilita salto

    private Rigidbody2D rb;//variable para llamar rigid body

    private Animator anim;//variable para llamar al animator

   public GameObject player;

    private bool direccion;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();
        
    }
    private void FixedUpdate()
    {
        Move(movement);
    }


    // Update is called once per frame
    void Update()
    {
        check_direction(direccion);
        Animation_control();
        movement.x = Input.GetAxis("Horizontal");
        
        
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;

        }


    }

    private void check_direction( bool direccion)
    {
        if(Input.GetKey(KeyCode.A))
        {
            direccion = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direccion = false;
        }
       
    }

    private void Animation_control()
    {
        
        if (direccion)
        {
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.GetComponent<SpriteRenderer>().flipX =false;
        }

        
    }

    private void Move(Vector2 movement)
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
        if (jump)
        {
            rb.velocity = Vector2.up * forceJump;
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            jump = false;
        }
    }




}
