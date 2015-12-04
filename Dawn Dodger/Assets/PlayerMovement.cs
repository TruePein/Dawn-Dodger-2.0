using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public static float maxSpeed;
    public static float timer;
    bool facingRight = true;
	// Use this for initialization
	void Start () 
    {
        maxSpeed = 250f;
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        float speedBoost = (timer > 0 ? 2f : 1f);
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        var move  = new Vector2(hMove * maxSpeed*speedBoost, vMove * maxSpeed*speedBoost);
        transform.GetComponent<Rigidbody2D>().AddForce(move);
        //transform.position += move * Time.deltaTime;
        if (hMove > 0 && !facingRight)
        {
            Flip();
           
        }else if (hMove < 0 && facingRight)
        {
            Flip();
        }
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        
    }
}
