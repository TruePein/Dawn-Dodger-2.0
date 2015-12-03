using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour {
    public static string go;
    Text text;
	// Use this for initialization
	void Awake () {
        go = "";
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = go;
	}
}
