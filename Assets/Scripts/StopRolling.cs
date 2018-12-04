using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRolling : MonoBehaviour {

    public Rigidbody rb;
    float val;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
    Vector3 decreaseVelocityByN(Vector3 original, int n)
    {
        float x = original.x/n;
        float y = original.y/n;
        float z = original.z/n;
        return new Vector3(x, y, z);
    }

	// Update is called once per frame
	void FixedUpdate () {
        val = rb.velocity.magnitude;
        //Debug.Log(val);
        Debug.Log(rb.velocity);
        if (val < 1.0f) { rb.velocity = Vector3.zero; }
        else {
            rb.velocity = new Vector3(decreaseVelocityByN(rb.velocity, 2).x, decreaseVelocityByN(rb.velocity, 2).y, decreaseVelocityByN(rb.velocity, 2).z);
            //rb.velocity = newVec3; 
            
        }
	}
}
