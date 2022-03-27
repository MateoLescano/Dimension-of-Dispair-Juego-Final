using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InicioNivel", menuName = "ScriptableObjects/InicioNivel", order = 1)]


//Valores asignados al principio de cada nivel
public class IniciiDeNivel : ScriptableObject
{
    public GameObject inicioNv;

    [HideInInspector]
    public Vector2 posicionInicial;

    public int vidaInicial;

}
