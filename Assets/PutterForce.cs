using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Applies an explosion force to all nearby rigidbodies
public class PutterForce : MonoBehaviour
{
    public float radius = 1.0F;
    public float power = 1.0F;
    public int level = 1;
    public AudioSource src;



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Debug.Log("Ball");
            Vector3 explosionPos = transform.position;
            Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z-5.0f);
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
           

            if (rb != null)
            {
                if (level == 1)
                {
                    //Debug.Log("Boom");
                    //rb.AddExplosionForce(power, explosionPos, radius, 2.0F);
                    src.Play();
                    rb.AddForce(transform.forward * 5.0f, ForceMode.Impulse);
                    //rb.AddForce(0f, 1.0f, 0f);//, ForceMode.Impulse);

                }
                if (level == 2)
                {
                    src.Play();
                    //Debug.Log("Boom");
                    //rb.AddExplosionForce(power, explosionPos, radius, 0.0F);
                    rb.AddForce(transform.right * 0.5f, ForceMode.Impulse);
                }

            }
        }
    }

}