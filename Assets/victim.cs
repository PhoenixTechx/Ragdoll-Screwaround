using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victim : MonoBehaviour {
    public Rigidbody RB;
    public float Force = 1000f;

	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            RB.AddForce(transform.forward * Force);
            //Decellerate when key is not down.
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(-transform.right * Force);
            //Decellerate when key is not down.
        }
        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(transform.right * Force);
            //Decellerate when key is not down.
        }
        if (Input.GetKey(KeyCode.S))
        {
            RB.AddForce(-transform.forward * Force);
            //Decellerate when key is not down.
        }

    }
}
