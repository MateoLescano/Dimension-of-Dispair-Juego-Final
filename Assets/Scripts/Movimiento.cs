using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    public float forceJump;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    Vector2 movement = Vector2.zero;
    bool jump;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move(movement);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
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
