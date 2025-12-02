using UnityEngine;

public class InventoryState : GameState
{
    public InventoryState(GameManagerScript manager) : base(manager) { }

    public override void Enter()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public override void Exit()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
