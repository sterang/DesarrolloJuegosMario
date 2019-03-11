using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoJ1 : MonoBehaviour {

    public Rigidbody rb1;
    public float FuerzaSalto1;
    static int NSaltos1 = 0;

    // Use this for initialization
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NSaltos1 += 1;
            if (NSaltos1 <= 1)
            {
                //rb.velocity = new Vector3(0, 10, 0);
                rb1.AddForce(new Vector3(0, FuerzaSalto1, 0), ForceMode.VelocityChange);
            }

        }
    }

    //Deteccion De Colision
    private void OnCollisionEnter(Collision collision)
    {
        NSaltos1 = 0;
    }
}
