using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    private int nvIndex;
    void Start()
    {
        nvIndex =SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Ganaste el nivel!");
        SceneManager.LoadSceneAsync(nvIndex+1);
    }
}
