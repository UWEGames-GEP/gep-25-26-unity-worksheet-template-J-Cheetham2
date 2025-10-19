using UnityEngine;

public class PausedState : GameState
{
    public PausedState(GameManagerScript manager) : base(manager) { }

    public override void Enter()
    {
        Time.timeScale = 0f;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameManager.SetPlayingState();
        }
    }
}
