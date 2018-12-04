using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Applies an explosion force to all nearby rigidbodies
public class ExampleClass : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    public AudioSource src;


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collide");
        if (col.gameObject.tag == "Ball")
        {
            Debug.Log("Ball");
            Vector3 explosionPos = transform.position;
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
           

            if (rb != null)
            {
                Debug.Log("Boom");
                src.Play();
                rb.AddExplosionForce(power, explosionPos, radius, 1.0F);
            }
        }
    }

}