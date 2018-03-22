using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour {

    public float Multiplier = 1;
    public float Speed = 20;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * (Speed * Time.deltaTime));
        transform.Translate(transform.up * Mathf.Sin(Time.time) * Multiplier);
        transform.Translate(transform.right * Mathf.Cos(Time.time) * Multiplier);
    }
}
