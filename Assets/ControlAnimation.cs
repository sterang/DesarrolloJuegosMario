using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public Animator animator5;
    public Animator animator6;
    public Animator animator7;
    public Animator animator8;
    public Animator animator9;
    public int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 0 ){
            animator1.CrossFadeInFixedTime("BajaCubo", 30);
            cont++;
        }
        
        //animator1.Play("BajaCubo");
    }
}
