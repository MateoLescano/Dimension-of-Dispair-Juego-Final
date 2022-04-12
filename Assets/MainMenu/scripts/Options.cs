using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject optionsCanvas;
    public Toggle screen;
    




    public void GoToOptions()
    {
        mainCanvas.SetActive(false);
        optionsCanvas.SetActive(true);
    }

    public void Fullscreen()
    {
       
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log(Screen.fullScreen);
    }
}
