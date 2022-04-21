using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Credits : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject creditCanvas;
    
    


    public void creditos()
    {
        mainCanvas.SetActive(false);
        creditCanvas.SetActive(true);
    
    }
}
