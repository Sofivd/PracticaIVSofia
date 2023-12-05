using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCrear : MonoBehaviour
{
    public GameObject MenuCrear;
    public GameObject Interfaz;
    public GameObject arbolVerde;
    public GameObject arbolMarron;
    
    public void CrearPulsado()
    {
        MenuCrear.gameObject.SetActive(true);
        Interfaz.gameObject.SetActive(false);
    }
    public void Arbol1()
    {
        arbolVerde.SetActive(true);
    }
    public void Arbol2()
    {
        arbolMarron.SetActive(true);
    }
}
