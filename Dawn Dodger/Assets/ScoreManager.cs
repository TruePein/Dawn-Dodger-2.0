using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    static Text text;
    public static int score;
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text>();
		score = 0;
		if (Application.loadedLevelName != "Scene1") {
			score = PlayerPrefs.GetInt("Score");
		}
		UpdateScoreText();
	}
	
	// Update is called once per frame
	public static void UpdateScoreText () {
        text.text = "Score: " + score;
	}

    public static void UpdateScore(int i)
    {
        score += i;
        UpdateScoreText();
        
    }
}
