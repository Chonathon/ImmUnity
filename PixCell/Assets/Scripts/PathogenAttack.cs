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

    // public GameObject infectedCell;


    private void CollisionEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag  == "RBC")
        {

            Destroy(collision.gameObject);
        }
    //    if (gameObject.tag == "RBC")
    //    if (gameObject.tag == "RBC")
    //    {
    //     Debug.Log("Direct Hit");
    //     Destroy(gameObject);
    //     Instantiate(infectedCell, collision.transform.position, Quaternion.identity);
    //    }
    }
}
