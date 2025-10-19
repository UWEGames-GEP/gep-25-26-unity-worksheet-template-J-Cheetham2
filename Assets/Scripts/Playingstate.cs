using UnityEngine;

public class PlayingState : GameState
{
    public PlayingState(GameManagerScript manager) : base(manager) { }

    public override void Enter()
    {
        Time.timeScale = 1f;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameManager.SetPausedState();
        }
    }
}
