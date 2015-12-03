using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
    int points = 10;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            ScoreManager.UpdateScore(points);
            Destroy(GetComponent<SpriteRenderer>());
            Destroy(this);
        }
    }
}
