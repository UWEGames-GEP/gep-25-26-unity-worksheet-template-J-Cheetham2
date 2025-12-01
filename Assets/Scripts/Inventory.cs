using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemObject> items = new List<ItemObject>();
    [SerializeField] private GameManagerScript gameManager;

    public void AddItem(ItemObject item)
    {
        items.Add(itemName);
    }

    public void RemoveItem(ItemObject item)
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
        if (gameManager == null || !(gameManager.CurrentState is PlayingState))
            return;

        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    AddItem("Generic Item");
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    RemoveItem("Generic Item");
        //}
    }

    //public List<string> GetItems()
    //{
    //    return new List<string>(items);
    //}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemObject collisionObject = hit.gameObject.GetComponent<ItemObject>();

        if (collisionObject != null)
        {
            AddItem(collisionObject);

            collisionObject.gameObject.SetActive(false);
        }
    }
}

