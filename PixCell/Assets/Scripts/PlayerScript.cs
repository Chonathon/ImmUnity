using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// <summary>
// Provides controls of the game object to the player
// </summary>
public class PlayerScript : MonoBehaviour

{

    private PlayerSwitchLogic logic;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        logic.ChangePlayer(this.gameObject);
        GetComponent<PlayerController>().enabled = true;
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
