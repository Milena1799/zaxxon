using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    GameObject objetoBola;
    Rigidbody rigidbodyBola;
    
      
    // Start is called before the first frame update
    void Start()
    {
    objetoBola = GameObject.Find("Bola");
        rigidbodyBola = objetoBola.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rigidbodyBola.useGravity = true;
        }
    }
}
