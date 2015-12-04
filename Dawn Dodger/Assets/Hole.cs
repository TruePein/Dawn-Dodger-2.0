using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" && ScoreManager.score >= 150)
        {
            if (Application.loadedLevelName == "Scene4")
            {
                PlayerMovement.maxSpeed = 0f;
                LightMovement.stopMovement();
                WinManager.win = "You Won!";
            }
            if (Application.loadedLevelName == "Scene1")
            {
               
                Application.LoadLevel("Scene3");
            }
            if (Application.loadedLevelName == "Scene3")
            {

                Application.LoadLevel("Scene4");
            }
        }

    }
}
