using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    // This inventory
    Dictionary<Item, int> inventory = new Dictionary<Item, int>();


    // Adds item to inventory
	public void AddToInventory(Item item)
    {
        if (inventory.ContainsKey(item))
        {
            Debug.Log(gameObject.name + ": " + item.itemName + " already exists. Incrementing.");
            inventory[item]++;
        }
        else
        {
            Debug.Log(gameObject.name + ": Adding " + item.itemName);
            inventory.Add(item, 1);
        }
    }

    public void RemoveFromInventory(Item item, int number)
    {
        if (inventory.ContainsKey(item))
        {
            if (inventory[item] > number)
            {
                Debug.Log(gameObject.name + ": Removing " + number + " " + item.itemName + "s.");
                inventory[item] -= number;
            }
            else if (inventory[item] == number)
            {
                Debug.Log(gameObject.name + ": Removing " + item.itemName + " from inventory");
                inventory.Remove(item);
            }
            else
            {
                Debug.Log(gameObject.name + ": Trying to remove too many " + item.itemName + "s");
            }
        }
        else
        {
            Debug.Log(gameObject.name + ": " + item.itemName + " is not in dictionary, cannot be removed.");
        }
    }


}
