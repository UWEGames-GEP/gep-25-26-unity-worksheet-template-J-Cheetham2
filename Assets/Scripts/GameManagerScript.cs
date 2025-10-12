using System;
using UnityEngine;

public enum Gamestate { paused, inGame };

public class GameManagerScript : MonoBehaviour

{
    public Gamestate state;
    private bool stateChanged;

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
                stateChanged = true;
            }
        }
        else if (state == Gamestate.paused)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = Gamestate.inGame;
                stateChanged = true;
            }
        }
    }
    private void LateUpdate()
    {
        if (stateChanged)
        {
            stateChanged = false;

            if (state == Gamestate.inGame)
            {
                Time.timeScale = 1.0f;
            }
            else if (state == Gamestate.paused)
            {
                Time.timeScale = 0.0f;
            }
        }
    }
}
