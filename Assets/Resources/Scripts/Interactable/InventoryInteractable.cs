using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An interactable inventory may be a chest, dead NPC 
/// or other non-player object with an inventory
/// </summary>
public class InventoryInteractable : Interactable {

    // Use this for initialization
    void Start () {
        Initialize();
        if (gameObject.GetComponent<Inventory>() == null)
        {
            Debug.LogError(gameObject.name + " No Inventory component attached");
        }
	}

    public override void Interact()
    {
        Debug.Log(gameObject.name + ": InventoryInteractable: Interact() called");
    }


}
