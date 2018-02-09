using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Should be attached to the player's camera
/// Raycasts ahead of the player to find interactable objects
/// </summary>
public class DetectInteractable : MonoBehaviour {

    public string interactableTag = "Interactable";

    public float RaycastDistance = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject InteractableObject = RaycastForInteractable();
        if (InteractableObject != null)
        {
            // Display Interact Text / Image

            // Check for KeyPress

            // If keypress, call interact

        }
	}

    GameObject RaycastForInteractable()
    {
        //Raycast in the direction the camera is looking
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit ObjectHit;

        if(Physics.Raycast(transform.position, fwd, out ObjectHit, RaycastDistance))
        {
            string tag = ObjectHit.transform.tag;
            if (tag == interactableTag)
            {
                Debug.Log("Interactable Object found");
                return ObjectHit.transform.gameObject;
            }
        }
        Debug.Log("No interactable found");
        return null;
    }
}
