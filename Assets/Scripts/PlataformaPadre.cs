using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPadre : MonoBehaviour
{

    public float distancia;
    public GameObject plataforma;
    private bool subiendo;


    [SerializeField] private float tiempoMovimiento;
    private float countDown;

    protected void DesplazamientoVertical()
    {
        if (subiendo)
        {
            plataforma.transform.position += new Vector3(0, distancia, 0) * Time.deltaTime;
        }
        else
        {
            plataforma.transform.position -= new Vector3(0, distancia, 0) * Time.deltaTime;
        }
    }

    protected void TimerMovimiento()
    {

        countDown -= Time.deltaTime;


        if (countDown > 0)
        {
            DesplazamientoVertical();
        }
        else
        {
            subiendo = !subiendo;
            ResetTimer();
        }

    }
    private void ResetTimer()
    {
        countDown = tiempoMovimiento;
    }

}
