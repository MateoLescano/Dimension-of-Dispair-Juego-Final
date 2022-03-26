using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject creditCanvas;




    public void Atras()
    {
        mainCanvas.SetActive(true);
        creditCanvas.SetActive(false);

    }
}
