using UnityEngine;

// <summary>
// Maps X and Y axis movement to arrow and wasd keys
// </summary>
public class PlayerController : MonoBehaviour

{
    // <summary>
    // Speed of movement
    // </summary>
    [SerializeField]
    private float MovementSpeed = 1;


    // Update is called once per frame
    private void Update()
    {
        // MovementSpeed
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * MovementSpeed;
        


    }
}


