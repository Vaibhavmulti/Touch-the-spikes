using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    public float speed=2f;
    public float flight = 4f;
    public static bool rightmov;
    Vector2 fly,left,right;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rightmov = true;
        fly = new Vector2(0f,flight);
        left = new Vector2(-speed, 0f);
        right = new Vector2(speed, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        
        if(rightmov)
        {
            rb.AddForce(right);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Moving right");
                rb.AddForce(fly);                
            }
        }
        if (!rightmov)
        {
            rb.AddForce(left);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(fly);
            }
        }
    }
}
