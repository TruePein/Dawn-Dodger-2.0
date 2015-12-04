using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	

    public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public void StartGame()
    {
        Application.LoadLevel("Scene1");
    }
}
