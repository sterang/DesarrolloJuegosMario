using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoJ2 : MonoBehaviour{

    public Rigidbody rb2;
    public float FuerzaSalto2;
    static int NSaltos2 = 0;

    // Use this for initialization
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Salto
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            NSaltos2 += 1;
            if (NSaltos2 <= 1)
            {
                //rb.velocity = new Vector3(0, 10, 0);
                rb2.AddForce(new Vector3(0, FuerzaSalto2, 0), ForceMode.VelocityChange);
            }

        }
    }

    //Deteccion De Colision
    private void OnCollisionEnter(Collision collision)
    {
        NSaltos2 = 0;
    }
}