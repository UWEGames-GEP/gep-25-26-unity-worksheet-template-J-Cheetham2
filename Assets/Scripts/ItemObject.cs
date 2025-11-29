using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [Header("Item Data")]
    [SerializeField] private string itemName;
    [SerializeField] private int value;
    [SerializeField] private string description;
    public string ItemName => itemName;
    public int Value => value;
    public string Description => description;
}
