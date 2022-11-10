using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// <summary>
// Maps slider to Spo2
// </summary>
public class Spo2Bar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxSPO2(float spo2)
    {
        slider.maxValue = spo2;
        slider.value = spo2;
    }

    public void SetSPO2(float spo2)
    {
        slider.value = spo2;
    }
}
