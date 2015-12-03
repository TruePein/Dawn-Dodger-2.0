using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinManager : MonoBehaviour {
    Text text;
    public static string win;
	// Use this for initialization
	void Awake () {
        win = "";
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = win;
	}
}
