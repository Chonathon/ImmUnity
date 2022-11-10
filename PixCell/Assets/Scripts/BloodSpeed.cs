using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// Moves a game object negatively along the x axis at a constant speed.
// </summary>
public class BloodSpeed : MonoBehaviour
{
    // <summary>
    // Controls the rate in which the game object travels
    // </summary>
      [SerializeField] 
      private float speed = 1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;  
    }
}
