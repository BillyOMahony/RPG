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

    public GameObject InteractText;

	// Use this for initialization
	void Start () {
		if(InteractText == null){
            Debug.LogError(gameObject.name + ": DetectInteractable: InteractText is not assigned");
        }
        else{
            SetupText();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject InteractableObject = RaycastForInteractable();
        EnableInteraction(InteractableObject);
    }

    /// <summary>
    /// Allows player to call the Interact method on the InteractableObject
    /// </summary>
    /// <param name="InteractableObject"></param>
    private void EnableInteraction(GameObject InteractableObject)
    {
        if (InteractableObject != null)
        {
            InteractText.SetActive(true);
            if (Input.GetButton("Interact"))
            {
                InteractableObject.GetComponent<Interactable>().Interact();
            }
        }
        else
        {
            InteractText.SetActive(false);
        }
    }

    void SetupText()
    {
        // find the canvas
        GameObject Canvas = GameObject.Find("Canvas");
        InteractText = Instantiate(InteractText, Canvas.transform);
        InteractText.SetActive(false);
    }

    /// <summary>
    /// Raycasts in front of the gameobject. If it finds a gameobject with
    /// interactableTag as the assigned tag it returns that gameobject
    /// </summary>
    /// <returns></returns>
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
                return ObjectHit.transform.gameObject;
            }
        }
        return null;
    }
}
