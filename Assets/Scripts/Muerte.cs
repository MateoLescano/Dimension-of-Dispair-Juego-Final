using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("Bala")){
            GameManager.instance.Daño();
            
        }else if(other.CompareTag("Damage")){

            GameManager.instance.Caida();
            GameManager.instance.RegenerateHearts();
        }
    }
}
