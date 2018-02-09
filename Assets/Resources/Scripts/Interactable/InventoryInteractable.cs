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
	}

    public override void Interact()
    {
        throw new System.NotImplementedException();
    }


}
