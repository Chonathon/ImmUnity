using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spo2Up : MonoBehaviour
{

    public SPO2 spo2;
    public float spo2AddSpeed = 1f;

    // Option 1 
    private void OnTriggerEnter2D(Collider2D collision)


    {
        if (collision.tag == "RBC")
        {

            spo2.addSpo2(spo2AddSpeed);

        }
    }
}
