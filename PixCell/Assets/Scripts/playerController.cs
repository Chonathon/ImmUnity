using UnityEngine;

public class playerController : MonoBehaviour

{
    public float MovementSpeed = 1;
    public float BloodSpeed = 1;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        // MovementSpeed
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * MovementSpeed;
        
        // BloodSpeed
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * BloodSpeed;



    }
}


