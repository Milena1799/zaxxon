using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeScript : MonoBehaviour
{
    [SerializeField] Text EnergyText;
    public float energy;

    private Vector3 Personaje = new Vector3(0f, 0f, 0f);
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        transform.position = Personaje;
    }
    // Update is called once per frame
    void Update()
    {
        float desp1H = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desp1H);
        float desplV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * Time.deltaTime * speed * desplV);
        float desplZ = Input.GetAxis("Profundidad");
        transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);

    }

        public void UpdateText ()
    {
        EnergyText.text = "ENERGÍA: " + energy + "%";
    }
}
