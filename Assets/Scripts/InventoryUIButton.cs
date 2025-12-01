using UnityEngine;
using TMPro;

public class InventoryUIButton : MonoBehaviour
{
    public TMP_Text buttonText;

    public void SetButton(ItemObject item)
    {
        buttonText.text = item.ItemName;
    }
}
