using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy_Bullet : MonoBehaviour
{
    private float speed;
    [SerializeField] private float timeToDestroy;
    private float countDown;
    private Vector2 move;
    private Rigidbody2D rb;


    void Start()
    {
        // Debug.Log("bala disparada");
        rb = transform.GetComponent<Rigidbody2D>();
        ResetTimer();
        velocidad();

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            move = Vector2.right;
        }else{    
            move = Vector2.left;
        }

    }

    void Update()
    {
        checkmove();
        Timer();
    }

    private void velocidad(){
        int numero = Random.Range(1, 7);

        switch (numero)
        {
            case 1:
                speed = 3;
                break;
            case 4:
                speed = 1;
                break;
            case 6:
                speed = 4;
                break;
            default:
                speed = 2;
                break;

        }
        
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


    private void OnTriggerEnter2D(Collider2D other) {

        Destroy(this.gameObject);

    }
}
