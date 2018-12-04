using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene("Hole 2", LoadSceneMode.Single);
        }
    }

}
