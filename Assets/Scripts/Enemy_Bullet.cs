using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToDestroy;
    private float countDown;
    private Vector2 move= Vector2.right;
    private Rigidbody2D rb;


    void Start()
    {
        Debug.Log("bala disparada");
        rb = transform.GetComponent<Rigidbody2D>();
        ResetTimer();
    }

    void Update()
    {
        checkmove();
        Timer();
    }


    private void ResetTimer()
    {
        countDown = timeToDestroy;
    }


    void checkmove()
    {

        rb.MovePosition(rb.position + move.normalized * speed * Time.fixedDeltaTime);

    }

    private void Timer()
    {

        countDown -= Time.deltaTime;


        if (countDown <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}
