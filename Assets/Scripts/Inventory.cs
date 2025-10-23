using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    private List<string> items = new List<string>();
    public GameManagerScript gameManager;

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }

    public void RemoveItem(string itemName)
    {
        if (items.Contains(itemName))
        {
            items.Remove(itemName);
        }
        else
        {
            Debug.Log(itemName + " not found in inventory");
        }
    }

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManagerScript>();
    }

    void Update()
    {
        if (gameManager == null || gameManager.GetCurrentStateName() != "PlayingState")
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddItem("Generic Item");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RemoveItem("Generic Item");
        }
    }

    public List<string> GetItems()
    {
        return new List<string>(items);
    }

}

