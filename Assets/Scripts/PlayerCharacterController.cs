using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class PlayerCharacterController : ThirdPersonController
{
    private GameManagerScript gameManager;

    private void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            if (gameManager != null)
            {
                gameManager = FindAnyObjectByType<GameManagerScript>();
            }
            if (gameManager != null)
            {
                gameManager.TogglePause();
            }
        }
    }
}
