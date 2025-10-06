using System;
using UnityEngine;

public enum Gamestate { paused, inGame };

public class GameManagerScript : MonoBehaviour

{
    public Gamestate state;

    void Start()
    {
        state = Gamestate.inGame;
    }

    void Update()
    {
        if (state == Gamestate.inGame)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = Gamestate.paused;
            }
        }
        else if (state == Gamestate.paused)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = Gamestate.inGame;
            }
        }
    }
}

