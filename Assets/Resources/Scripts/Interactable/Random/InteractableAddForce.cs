using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableAddForce : Interactable {

    private Rigidbody rb;

    public Vector3 ForceDirection = new Vector3(0, 1, 0);
    public float ForceMultiplier = 100f;
    public float RandomOffsetMaximum = 0.1f; 

    public override void Interact()
    {
        Vector3 offset = GetRandomDirectionOffset(RandomOffsetMaximum);
        rb.AddForce((ForceDirection + offset) * ForceMultiplier);  
    }

    // Use this for initialization
    void Start () {
        Initialize();
        if ((rb = GetComponent<Rigidbody>()) == null)
        {
            rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        }
    }
	
	Vector3 GetRandomDirectionOffset(float OffsetAmount)
    {
        return new Vector3(Random.Range(OffsetAmount * -1, OffsetAmount),
                Random.Range(OffsetAmount * -1, OffsetAmount),
                Random.Range(OffsetAmount * -1, OffsetAmount)
            );
    }


}
