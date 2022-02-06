using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    public GameObject bullet;//prefab de la bala
    public float timeSummonBullet;
    private float summonTime;
    private Animator anim;

    private void SummonBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        ResetTimer();
    }
    private void ResetTimer()
    {
        summonTime = timeSummonBullet;
    }
    void Start()
    {
        ResetTimer();
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        Timer();
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
}
