using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Player : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Damage"))
        {
            anim.SetTrigger("TakeDamageTrigger");
            Debug.Log("daño");
        }
    }

}
