using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour
{
    [SerializeField] Transform personaje;
    [SerializeField] PersonajeScript personajeScript;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        MoverCamara();
    }

    void MoverCamara()
    {
        transform.LookAt(personaje);
    }
}
