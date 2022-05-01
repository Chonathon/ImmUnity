using UnityEngine;


public class SPO2 : MonoBehaviour
{

    public float maxSpo2 = 90.0f;
    public float currentSpo2;
    public float spo2DropSpeed = 1f;
    public float spo2AddSpeed = 1f;

    public SPO2Bar spo2Bar;

    public void addSpo2(float spo2AddSpeed)
    {
            Debug.Log("Working");
            currentSpo2 += spo2AddSpeed;
            spo2Bar.SetSPO2(currentSpo2);
            // currentSpo2 = Mathf.Clamp(currentSpo2 + _value, 0, maxSpo2);
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
