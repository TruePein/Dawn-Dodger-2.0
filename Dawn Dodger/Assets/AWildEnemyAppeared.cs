using UnityEngine;
using System.Collections;

public class AWildEnemyAppeared : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		}
	}

	void OnTriggerExit2D (Collider2D col) {
		if (col.tag == "Player") {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		}
	}
}
