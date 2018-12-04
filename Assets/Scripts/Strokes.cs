using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strokes : MonoBehaviour {

    public GameObject statObj;
    public Stats statScript;
    private int strokeHelper;

    void Start()
    {

            statScript = statObj.GetComponent("Stats") as Stats;
            strokeHelper = 0;
       
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Club")
        {

            if (strokeHelper == 1)
            {
                strokeHelper = 0;
                statScript.strokes++;
            }
            else
            {
                strokeHelper++;
            }
        }

    }

}
