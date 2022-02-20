using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int vida;

    public GameObject player;

    public Image[] hearts = new Image [3];

    private void Awake() {
        if(instance == null){
            instance = this;


        }
    }
    
    void Start()
    {
        vida = 3;
        
    }

    
    void Update()
    {
        Dead();
    }

    public void Daño(){
        //for (int vida = 3; vida <= 0; vida--)
        //{
        //    Debug.Log(vida);
        //    hearts[vida].enabled = false;
        //}
        vida--;
        hearts[vida].enabled = false;

    }

    private void Dead(){
        if(vida <= 0){
            Debug.Log("Has muerto");
            player.transform.position = new Vector3(30.4f, -1.16f, 0);
            vida = 3;
            RegenerateHearts();
            
        }
    }

    public void RegenerateHearts()
    {
        hearts[0].enabled = true;
        hearts[1].enabled = true;
        hearts[2].enabled = true;
    }

}
