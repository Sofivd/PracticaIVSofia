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

        if (Input.GetMouseButtonDown(0))
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit crear;
            if (Physics.Raycast(rayoCamara, out crear))
            {
               // GameObject.Instantiate(arbolVerde, crear.point);
            }
        }
    }
    public void Arbol2()
    {
        arbolMarron.SetActive(true);
    }
}
