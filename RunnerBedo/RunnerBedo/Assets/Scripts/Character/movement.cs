using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    
    public static float forwardSpeed=3f;
    public static  Animator anim;

   
    private void Awake()
    {
        anim = GetComponent<Animator>();
        
    }
    private void Update()
    {
        forwardSpeed = 3f;
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
        if (forwardSpeed==0)
        {
            anim.SetBool("running", false);
        }
        else if (forwardSpeed>0)
        {
            anim.SetBool("running", true);
        }
    }
   
}
