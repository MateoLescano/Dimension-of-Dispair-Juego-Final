using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementForce;
    [SerializeField]
    private float forceJump;
    [SerializeField]
    private float fallingGravity = 1.5f;

    [Header("Variables de colisi�n")]
    [SerializeField]
    private GameObject patas;
    [SerializeField]
    private LayerMask suelo;

    private Vector2 movement = Vector2.zero;//movimiento izquierda-derecha || izquierda x<0 y derecha x>0

    private Rigidbody2D rb;//variable para llamar rigid body

    private Animator anim;//variable para llamar al animator

    private SpriteRenderer sprite;

    private bool direccion, touchingFloor, isFalling, isJumping;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Inputs();
        Animation_control();
        FalllingStuff();
    }

    private void FalllingStuff()
    {
        rb.gravityScale = isFalling ? fallingGravity : 1;
        if  (isFalling) isJumping = false;
    }

    void FixedUpdate()
    {
        Jump_colision_floor();
        Move();
    }

    private void Inputs()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if (movement.x != 0) direccion = movement.x < 0;


        if (Input.GetKeyDown(KeyCode.Space) && touchingFloor)
        {
            Jump();
        }

        isFalling = !touchingFloor && rb.velocity.y < 0;
        if (Input.GetKeyUp(KeyCode.Space) && !isFalling)
        {
            Stop_Jump();
        }
    }

    private void Stop_Jump()
    {
        isJumping = false;
        rb.velocity = new Vector2(rb.velocity.x, 0);
    }

    private void Jump_colision_floor()
    {
        RaycastHit2D hit = Physics2D.Raycast(patas.transform.position, Vector2.down, .2f, suelo.value);//se puede cambair a box
        Debug.DrawLine(patas.transform.position, patas.transform.position + Vector3.down * .2f, Color.yellow);

        touchingFloor = hit.collider != null;
    }

    private void Animation_control()
    {
        sprite.flipX = direccion;  

        bool isRunning = Mathf.Abs(rb.velocity.x) >= .5f;
        anim.SetBool("Run", isRunning);
        anim.SetBool("Fall", isFalling);
        anim.SetBool("Jump", isJumping);
    }

    private void Move()
    {
        rb.AddForce(movement.normalized * movementForce, ForceMode2D.Force);
    }

    private void Jump()
    {
        anim.SetTrigger("TriggerJump");
        isJumping = true;
        rb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
    }

}
