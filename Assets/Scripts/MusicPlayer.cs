using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    private void Awake()
    {
        int numberOfPlayers = FindObjectsOfType<MusicPlayer>().Length;

        if (numberOfPlayers > 1) //singleton pattern
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
