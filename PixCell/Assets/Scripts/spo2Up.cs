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



    // Option 2
    // public SPO2 spo2;
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     // if (collision.tag == "RBC")
    //     // {
    //     //     Debug.Log("Trigger");
    //     //     // collision.GetComponent<SPO2>().addSpo2(spo2AddSpeed);
    //     //     collision.spo2.addSpo2(spo2AddSpeed);
    //     // }

// Option 3
    // [SerializeField] private float addValue;

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.tag == "Player")
    //     {
    //         collision.GetComponent<SPO2>().addSpo2(addValue);
    //     }
    // }
    


    // Option 1
    // public SPO2 spo2;
    
    // public float spo2UpSpeed = 10.0f;
    
    // void Awake()
    // {
    //     spo2 = FindObjectOfType<SPO2>();
    // }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (Input.GetKeyDown(KeyCode.E))
    //     // if (spo2.currentSpo2 < spo2.maxSpo2)
    //     {
    //         spo2.currentSpo2 = spo2.currentSpo2 + spo2UpSpeed;
    //     }
    // }
}
