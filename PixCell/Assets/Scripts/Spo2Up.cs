using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// Increases Spo2 on collision with a chosen object
// </summary>
public class Spo2Up : MonoBehaviour
{

    // <summary>
    // Rate at which spo2 is increased
    // </summary>
    public float Spo2AddSpeed = 1f;

    public Spo2 spo2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "RBC")
        {

            spo2.addSpo2(Spo2AddSpeed);

        }
    }
}
