using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
			if (Application.loadedLevelName == "Scene4" && ScoreManager.score >= 510)
            {
                PlayerMovement.maxSpeed = 0f;
                LightMovement.stopMovement();
                WinManager.win = "You Won!";
            }
			if (Application.loadedLevelName == "Scene1" && ScoreManager.score >= 150)
            {
				PlayerPrefs.SetInt("Score", ScoreManager.score);
				PlayerPrefs.Save();
                Application.LoadLevel("Scene3");
            }
            if (Application.loadedLevelName == "Scene3")
            {
				PlayerPrefs.SetInt("Score", ScoreManager.score && ScoreManager.score >= 320);
				PlayerPrefs.Save();
                Application.LoadLevel("Scene4");
            }
        }

    }
}
