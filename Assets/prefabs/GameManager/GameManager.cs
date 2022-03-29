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

    private Animator anim;


    public Image[] hearts = new Image [3];

    private void Awake() {
        if(instance == null){
            instance = this;


        }
    }
    
    void Start()
    {
        vida = valoresIniciales.vidaInicial;
        anim = player.GetComponent<Animator>();
        valoresIniciales.posicionInicial = player.transform.position;



    }

    
    void Update()
    {
        Dead();
        Exit();
    }

    public void Daño(){

        vida--;
        hearts[vida].enabled = false;
        anim.SetTrigger("TakeDamageTrigger");

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

    public void Exit()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("se salio");
            Application.Quit();
        }
    }



}
