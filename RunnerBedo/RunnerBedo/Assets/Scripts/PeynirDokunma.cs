using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeynirDokunma : MonoBehaviour
{
    public GameObject toplanacakYer;
    public GameObject food;

    void Start()
    {
        food = this.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            toplanacakYer.GetComponent<Altýn>().sayac++;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
