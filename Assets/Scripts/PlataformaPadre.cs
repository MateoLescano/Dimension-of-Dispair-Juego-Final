using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPadre : MonoBehaviour
{
    [Tooltip("unidades por segundo")]
    public float velocidad;
    public GameObject plataforma;
    private bool subiendo;

    private Rigidbody2D playerRb;


    [SerializeField] private float tiempoMovimiento;
    private float countDown;

    protected void DesplazamientoVertical()
    {
        int direccion = subiendo ? 1 : -1;

        plataforma.transform.position += new Vector3(0, velocidad * direccion, 0) * Time.deltaTime;

        if (playerRb != null)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, velocidad *direccion);
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        playerRb = other.gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        playerRb = null;
    }

}
