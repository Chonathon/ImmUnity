using UnityEngine;

// <summary>
// Sets the numerical values of Spo2Bar
// </summary>
public class Spo2 : MonoBehaviour
{
    // <summary>
    // Maximum and starting value
    // </summary>
    public float maxSpo2 = 90.0f;
    
    // <summary>
    // Current value
    // </summary>
    public float currentSpo2;

    // <summary>
    // Diminishing rate
    // </summary>
    public float spo2DropSpeed = 1f;

    // <summary>
    // Increasing rate
    // </summary>
    public float spo2AddSpeed = 1f;

    public Spo2Bar spo2Bar;

    public void addSpo2(float spo2AddSpeed)
    {
            currentSpo2 += spo2AddSpeed;
            spo2Bar.SetSPO2(currentSpo2);
    }

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


    }
    // public void SP
}
