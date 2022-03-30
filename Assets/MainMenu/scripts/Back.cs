using UnityEngine;
using UnityEngine.SceneManagement;


public class Back : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject creditCanvas;




    public void Atras()
    {
        mainCanvas.SetActive(true);
        creditCanvas.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
