using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleHealth : MonoBehaviour
{
    public Image bar;
    public RectTransform button;
    public static float healtValue =0;
   

    void Update()
    {
        
        healthChange(healtValue);
    }
    void healthChange(float health)
    {
        float amount = (healtValue / 100.0f) * 180 / 360;
        bar.fillAmount = amount;
        float buttonAngel = amount * 360;
        button.localEulerAngles = new Vector3(0, 0, -buttonAngel);
    }
}
