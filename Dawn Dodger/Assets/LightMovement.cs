using UnityEngine;
using System.Collections;

public class LightMovement : MonoBehaviour {
    public static float MovementSpeed = 100f;
	// Use this for initialization
	void Start () {
        
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        var move = new Vector2(MovementSpeed, 0);
        transform.GetComponent<Rigidbody2D>().AddForce(move);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            PlayerMovement.maxSpeed = 0f;
            stopMovement();
            GameOverManager.go = "Game Over!";
        }
    }
    public static void stopMovement()
    {
        MovementSpeed = 0f;
    }
}
