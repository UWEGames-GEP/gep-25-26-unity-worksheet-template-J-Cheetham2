using UnityEngine;

public abstract class GameState
{
    protected GameManagerScript gameManager;

    public GameState(GameManagerScript manager)
    {
        gameManager = manager;
    }

    public virtual void Enter() {}
    public virtual void Update() {}
    public virtual void Exit() {} 
}