using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("Damage")){
        Debug.Log("Has muerto");
        player.transform.position = new Vector3(30.4f, -0.53f, 0);
        }
    }
}
