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
            if (gameManager == null)
            {
                gameManager = FindAnyObjectByType<GameManagerScript>();
            }
            if (gameManager != null)
            {
                gameManager.TogglePause();
            }
        }
    }
    private void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Inventory inventory = GetComponent<Inventory>();

            if (inventory != null)
            {
                inventory.RemoveItem();
            }
        }
    }
    private void OnInventory (InputValue value)
    {
        if (value.isPressed)
        {
            if (gameManager == null) gameManager = FindAnyObjectByType<GameManagerScript>();

            if (gameManager != null)
            {
                gameManager.ToggleInventory();
            }
        }
    }
}
