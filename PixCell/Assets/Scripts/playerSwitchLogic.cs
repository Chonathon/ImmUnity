using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSwitchLogic : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]

    GameObject CurrentPlayer;

    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<playerController>().enabled = false;
        }
        CurrentPlayer = Players[0];
    }

    public void ChangePlayer(GameObject player) 
    {
        CurrentPlayer.GetComponent<playerController>().enabled = false;
        CurrentPlayer = player;
    }

}
