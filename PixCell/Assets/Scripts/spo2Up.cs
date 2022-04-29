using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spo2Up : MonoBehaviour
{
    public SPO2 spo2;
    
    public float spo2UpSpeed = 10.0f;
    
    void Awake()
    {
        spo2 = FindObjectOfType<SPO2>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        // if (spo2.currentSpo2 < spo2.maxSpo2)
        {
            spo2.currentSpo2 += spo2UpSpeed;
        }
    }
}
