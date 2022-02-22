using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    private Vector3 startPosition;
    public float tekrar;
    public float magnitude;
    public float offset;
    private Animation anim1;
    public Animator anim;
    void Start()
    {
        startPosition = transform.position;
        anim = GetComponent<Animator>();
        anim1 = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("don", true);
        transform.position = startPosition + transform.up * Mathf.Cos(Time.deltaTime*tekrar * offset) * magnitude;
    }
}
