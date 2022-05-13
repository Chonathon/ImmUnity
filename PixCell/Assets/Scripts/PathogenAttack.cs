using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// WIP
// - Destroys game objects tagged 'RBC'
// - Instantiates game object of same type
// </summary>
public class PathogenAttack : MonoBehaviour
{

    public GameObject infectedCell;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag  == "RBC")
        {
            Instantiate(infectedCell, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
