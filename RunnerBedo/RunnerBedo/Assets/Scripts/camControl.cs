using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    public Transform target;
    public static Vector3 offset;
    
    public float lerpValue;


    private void Start()
    {
        offset.x = 0;
        offset.y = 2.038f;
        offset.z = -3f;
    }
    private void LateUpdate()
    {
        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
  

}
