using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaCubo1 : MonoBehaviour {

    public GameObject CentroCubo;
    public GameObject ModeloMoneda;
    public GameObject ModeloCubo;
    GameObject MonedaClon;
    public float FuerzaMoneda;
    public int NumeroMonedas;
    private float time = 9/10;
    public AudioSource monedaAudio;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.X))
        {
            SaltaMoneda();
        }

        if (NumeroMonedas <= 0)
        {
            Destroy(ModeloCubo, time);
        }

    }

    //Deteccion De Colision
    private void OnCollisionEnter(Collision collision)
    {
        if(NumeroMonedas>=1)
        {
            SaltaMoneda();
            NumeroMonedas -= 1;
        }
        else if(NumeroMonedas<=0)
        {
            Destroy(ModeloCubo, 1);
        }
        
    }

    void SaltaMoneda()
    {
        MonedaClon = Instantiate(ModeloMoneda, CentroCubo.GetComponent<Transform>().position, Quaternion.identity);
        MonedaClon.GetComponent<Rigidbody>().AddForce(new Vector3(0, FuerzaMoneda, 0), ForceMode.VelocityChange);
        Destroy(MonedaClon, 1);
        monedaAudio.Play();
    }
}

