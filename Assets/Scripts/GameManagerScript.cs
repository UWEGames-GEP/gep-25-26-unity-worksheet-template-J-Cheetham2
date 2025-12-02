using System;
using UnityEngine;

public enum Gamestate { paused, inGame };

public class GameManagerScript : MonoBehaviour
{
    public Gamestate state;

    public GameObject inventoryUI;
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

    void LateUpdate()
    {
        if (currentState is PlayingState)
        {
            if (inventoryUI != null) inventoryUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (currentState is PausedState)
        {
            if (inventoryUI != null) inventoryUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
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

    public void TogglePause()
    {
        if (currentState is PlayingState)
        {
            SetPausedState();
        }
        else if (currentState is PausedState)
        {
            SetPlayingState();
        }
    }
}