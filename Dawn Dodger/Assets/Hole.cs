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
            PlayerMovement.maxSpeed = 0f;
            LightMovement.stopMovement();
            WinManager.win = "You Won!";
        }
    }
}
