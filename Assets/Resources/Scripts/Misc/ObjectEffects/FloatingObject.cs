using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour {

    public float Multiplier = 1;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, Mathf.Sin(Time.time) * Multiplier, 0);
	}
}
