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
}
