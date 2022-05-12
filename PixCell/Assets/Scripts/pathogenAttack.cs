using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathogenAttack : MonoBehaviour
{



    public GameObject infectedCell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collider2D collision)
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
