using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour

{

    public playerSwitchLogic logic;

    void OnMouseDown()
    {
        logic.ChangePlayer(this.gameObject);
        GetComponent<playerController>().enabled = true;

            
    }




    // public GameObject otherPlayer;
    // private void Update () 
    // {


    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         otherPlayer.GetComponent<playerController>().enabled = false;
    //         GetComposnent<playerController>().enabled = true;
    //     }
    // }

// void OnMouseDown()
// {
//         otherPlayer.GetComponent<playerController>().enabled = false;
//         GetComponent<playerController>().enabled = true;
// }

}
