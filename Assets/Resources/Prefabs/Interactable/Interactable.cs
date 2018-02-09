using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {

    public string tagToAssign = "Interactable";

    void Start()
    {
        AssignTag();
    }

    public abstract void Interact();

    protected void AssignTag()
    {
        gameObject.tag = tagToAssign;
    }

}
