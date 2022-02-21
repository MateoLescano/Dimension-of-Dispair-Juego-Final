using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public IniciiDeNivel valoresIniciales;

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
        vida = valoresIniciales.vidaInicial;

    }

    
    void Update()
    {
        Dead();
    }

    public void Daño(){

        vida--;
        hearts[vida].enabled = false;

    }

    private void Dead(){
        if(vida <= 0){
            Debug.Log("Has muerto");
            Caida();
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

    public void Caida()
    {
        player.transform.position = valoresIniciales.posicionInicial;
    }



}
