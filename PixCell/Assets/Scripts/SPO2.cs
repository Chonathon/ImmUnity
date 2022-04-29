using UnityEngine;


public class SPO2 : MonoBehaviour
{

    public float maxSpo2 = 90.0f;
    public float currentSpo2;
    public float spo2DropSpeed = .1f;

    public SPO2Bar spo2Bar;

    void Start()
    {
        currentSpo2 = maxSpo2;
        spo2Bar.SetMaxSPO2(maxSpo2);
    }

    void Update()
    {
        if (currentSpo2 > 0.0f)
        {
        currentSpo2 -= spo2DropSpeed * Time.deltaTime;
        spo2Bar.SetSPO2(currentSpo2);
        }
        // if (currentSpo2 > 0)
        // {
        //    currentSpo2 -= Time.deltaTime;
        //    spo2Bar.SetSPO2(currentSpo2);
        // }
        // DropSpo2(1) * Time.deltaTime;
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //    DropSpo2(1);
        // }

    // void DropSpo2(int drop)
    // {
    //     currentSpo2 -= drop;
    //     spo2Bar.SetSPO2(currentSpo2);
    // }
        // currentSpo2 -= spo2DropSpeed * Time.deltaTime;

    }
}
