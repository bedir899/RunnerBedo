using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            CircleHealth.healtValue -= 25;
        }
        Destroy(this.gameObject);
    }
}
