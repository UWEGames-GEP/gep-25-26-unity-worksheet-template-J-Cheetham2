using UnityEngine;

public class PotionItem : ItemObject
{
    [Header("Potion Data")]
    [SerializeField] private int restoreHPAmount;
    public int RestoreHPAmount => restoreHPAmount;
}
