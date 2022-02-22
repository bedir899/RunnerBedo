using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl2 : MonoBehaviour
{
    public Transform target;
    public  Vector3 offfset;

    public float lerpValue;
    private void LateUpdate()
    {
        Vector3 desPos = target.position + offfset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }


}
