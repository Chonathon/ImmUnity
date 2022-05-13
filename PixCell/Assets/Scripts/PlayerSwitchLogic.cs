using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitchLogic : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]

    GameObject CurrentPlayer;
    // TODO:
    // - Figure out how to stop clones from being controlled
    // -> Consider creating an area out of Player tags

    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<PlayerController>().enabled = false;
        }
        // CurrentPlayer = Players[0];
        

    }

    void Update()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
    }

    public void ChangePlayer(GameObject player) 
    {
        CurrentPlayer.GetComponent<PlayerController>().enabled = false;
        CurrentPlayer = player;
    }

}
