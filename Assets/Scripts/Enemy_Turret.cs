using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Turret : MonoBehaviour
{
    public GameObject bullet;//prefab de la bala
    public float timeSummonBullet;
    private float summonTime;
    private Animator anim;

    public LayerMask playerLayer;

    public float distance;

    private bool detectado;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        ResetTimer();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        detectado = false;        
    }

    void Update()
    {
        Raycast();
        if(detectado){
            Timer();
        }
        
    }

    private void SummonBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        ResetTimer();
    }
    private void ResetTimer()
    {
        summonTime = timeSummonBullet;
    }

    private void Timer()
    {

        summonTime -= Time.deltaTime;
        if (summonTime <= 0)
        {
            anim.SetTrigger("Shoot");
            SummonBullet();

        }
    }

    private void Raycast(){

        if(spriteRenderer.flipX == true){
            Debug.DrawRay(transform.position,Vector2.right * distance, Color.black);

            if(Physics2D.Raycast(transform.position, Vector2.right, distance, playerLayer)){
                detectado = true;
                Debug.Log("DETECTADO");
            }
        }else{
            Debug.DrawRay(transform.position,Vector2.left * distance, Color.black);

            if(Physics2D.Raycast(transform.position, Vector2.left, distance, playerLayer)){
                detectado = true;
                Debug.Log("DETECTADO");
            }
        }

        

    }

}
