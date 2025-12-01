using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();

    private void OnEnable()
    {
        RefreshInventory();
    }

    void RefreshInventory()
    {
        foreach (GameObject uiButton in inventoryUIButtons)
        {
            uiButton.SetActive(false);
        }
        for (int unit = 0; unit < inventory.items.Count; unit++)
        {
            if (unit < inventoryUIButtons.Count)
            {
                GameObject buttonObject = inventoryUIButtons[unit];
                ItemObject item = inventory.items[unit];

                buttonObject.SetActive(true);
                buttonObject.GetComponent<InventoryUIButton>().SetButton(item);
            }
        }
    }
}
