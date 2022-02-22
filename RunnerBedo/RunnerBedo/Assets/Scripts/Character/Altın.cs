using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altın : MonoBehaviour
{
    public  int sayac;
    public  Text sayacText;
    public static int sayacDegis;


    void Update()
    {
        
        if (sayac <= 0)
        {
            sayac = 0;
        }
        sayacText.text = "SCORE:" + sayac  ;
        sayacDegis = sayac;
        int sayacTopla = PlayerPrefs.GetInt("sayacTopla", sayacDegis);
        PlayerPrefs.SetInt("sayacTopla", sayacDegis);
    }
    
}
