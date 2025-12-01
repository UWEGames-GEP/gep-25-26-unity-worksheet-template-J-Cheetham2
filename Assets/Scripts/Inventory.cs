using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [SerializeField] public List<ItemObject> items = new List<ItemObject>();
    [SerializeField] private GameManagerScript gameManager;
    private Transform worldItemsTransform;

    public void AddItem(ItemObject item)
    {
        items.Add(item);
    }

    public void RemoveItem(ItemObject item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Debug.Log(item.ItemName + " not found in inventory");
        }
    }

    public void RemoveItem()
    {
        if (gameManager.CurrentState is PlayingState && items.Count > 0)
        {
            ItemObject item = items[0];

            Vector3 spawnPosition = transform.position + transform.forward;
            spawnPosition += new Vector3(0, 1, 0);

            Quaternion spawnRotation = transform.rotation * Quaternion.Euler(0, 180, 0);
            GameObject newItem = Instantiate(item.gameObject, spawnPosition, spawnRotation, worldItemsTransform);

            newItem.SetActive(true);
            items.Remove(item);
            Destroy(item.gameObject);
        }
    }

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManagerScript>();
        worldItemsTransform = GameObject.Find("World Items").transform;
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

