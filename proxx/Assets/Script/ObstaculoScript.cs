using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoScript : MonoBehaviour
{
    public GameObject otroObject;
    private PersonajeScript personajeScript;  


    // Start is called before the first frame update
    void Start()
    {
        personajeScript = otroObject.GetComponent<PersonajeScript>();
        personajeScript.energy = 75 ;
        personajeScript.SendMessage("UpdateText");

      

    }

    
   
}
