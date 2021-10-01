using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeScript : MonoBehaviour
{
    [SerializeField] Text EnergyText;
    public float energy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void UpdateText ()
    {
        EnergyText.text = "ENERGÍA: " + energy + "%";
    }
}
