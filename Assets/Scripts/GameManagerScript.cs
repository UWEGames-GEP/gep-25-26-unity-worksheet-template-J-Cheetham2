using System;
using UnityEngine;

public enum Gamestate { paused, inGame };

public class GameManagerScript : MonoBehaviour
{
    public Gamestate state;

    private GameState currentState;
    public GameState CurrentState => currentState;
    private PlayingState playingState;
    private PausedState pausedState;

    void Start()
    {
        playingState = new PlayingState(this);
        pausedState = new PausedState(this);
        ChangeState(playingState);
    }

    void Update()
    {
        currentState?.Update();
    }

    public void ChangeState(GameState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }

    public void SetPausedState()
    {
        ChangeState(pausedState);
    }

    public void SetPlayingState()
    {
        ChangeState(playingState);
    }
}