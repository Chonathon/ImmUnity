using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPO2Bar : MonoBehaviour
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
