using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject CentroCubo1;
    public GameObject ModeloMoneda;
    GameObject MonedaClon;
    public float FuerzaMoneda;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Deteccion De Colision
    private void OnCollisionEnter(Collision collision)
    {
        SaltaMoneda();
    }

    void SaltaMoneda()
    {
        MonedaClon = Instantiate(ModeloMoneda, CentroCubo1.GetComponent<Transform>().position, Quaternion.identity);
        MonedaClon.GetComponent<Rigidbody>().AddForce(new Vector3(0, FuerzaMoneda, 0));
    }
}
