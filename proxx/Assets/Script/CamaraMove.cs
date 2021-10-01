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
        float newX = personajeScript.transform.position.x;
        float newY = personajeScript.transform.position.y;
        float newZ = transform.position.z;
        transform.LookAt(personaje);
        transform.position = new Vector3(newX, newY, newZ);
    }
       
}
