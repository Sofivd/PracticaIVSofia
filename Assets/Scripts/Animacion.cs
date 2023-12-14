using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
       LeanTween.scale(panel, new Vector3(0.5f,0.2f,0.3f),0.5f).setEaseInElastic().setLoopClamp(2); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
