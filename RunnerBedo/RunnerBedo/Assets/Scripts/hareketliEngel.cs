using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketliEngel : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
