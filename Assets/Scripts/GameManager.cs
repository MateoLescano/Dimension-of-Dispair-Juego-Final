using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int vida;

    public GameObject player;

    private void Awake() {
        if(instance == null){
            instance = this;


        }
    }
    // Start is called before the first frame update
    void Start()
    {
        vida = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        Muerte();
    }

    public void Daño(){
        vida--;
    }

    private void Muerte(){
        if(vida <= 0){
            Debug.Log("Has muerto");
            player.transform.position = new Vector3(30.4f, -0.53f, 0);
            vida = 3;
        }
    }
}
