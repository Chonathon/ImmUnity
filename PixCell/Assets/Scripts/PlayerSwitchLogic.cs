using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitchLogic : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]

    public GameObject CurrentPlayer;
    // TODO:

    void Start()
    {

        // CurrentPlayer = Players[0];
    }

    void Update()
    {


        
        
        
        Players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in Players)
        {
            if (player != CurrentPlayer)
            {
                player.GetComponent<PlayerController>().enabled = false;
                player.GetComponent<WbcAttack>().enabled = false;
            }
        }
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<PlayerController>().enabled = false;
        }
    }

    public void ChangePlayer(GameObject player) 
    {
        CurrentPlayer.GetComponent<PlayerController>().enabled = false;
        CurrentPlayer = player;
    }

}
