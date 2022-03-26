using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovediza : PlataformaPadre
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            TimerMovimiento();
            DesplazamientoVertical();
 
    }

    private void OnCollisionEnter2D(Collision2D other) {
        other.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D other) {
        other.collider.transform.SetParent(null);
    }
}
