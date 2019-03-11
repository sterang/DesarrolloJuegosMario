using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJ1 : MonoBehaviour {

    public Transform PersonajeM1;
    public float Velocidad1;
    public float VelocidadRotacion1;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento direccion flechas
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PersonajeM1.Translate(Velocidad1 * Time.deltaTime * Vector3.forward);
            animator.SetBool("Caminar", true);
        }
        else
        {
            animator.SetBool("Caminar", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PersonajeM1.Translate(Velocidad1 * Time.deltaTime * Vector3.back);
            animator.SetBool("Caminar", true);
        }
        
        //animator.SetBool("Caminar", false);
        //if(Input.GetKey(KeyCode.RightArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.right);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.left);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PersonajeM1.Rotate(Vector3.down * VelocidadRotacion1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            PersonajeM1.Rotate(Vector3.up * VelocidadRotacion1);
        }
           

        //Rotacion
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    PersonajeM1.Rotate(Vector3.down * VelocidadRotacion1);
        //if (Input.GetKey(KeyCode.RightArrow))
        //    PersonajeM1.Rotate(Vector3.up * VelocidadRotacion1);

    }


}
