using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("se salio");
        Application.Quit();
    }
}
