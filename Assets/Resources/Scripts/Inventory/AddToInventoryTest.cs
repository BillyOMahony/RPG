using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventoryTest : MonoBehaviour {

    public GameObject inventoryObj;
    public GameObject itemObj;
    public Inventory inventory;
    public Item item;

    private void GetInvAndItem()
    {
        this.inventory = inventoryObj.GetComponent<Inventory>();
        this.item = itemObj.GetComponent<Item>();
    }

    public void ClickAdd()
    {
        GetInvAndItem();
        inventory.AddToInventory(item);
    }

    public void ClickRemove()
    {
        GetInvAndItem();
        inventory.RemoveFromInventory(item, 1);
    }

}
