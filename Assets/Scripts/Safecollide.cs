using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safecollide : MonoBehaviour {
    public Spawn1 tr2;
    public Spawn tr1;
	// Use this for initialization
	void Start () {
        tr2 = GameObject.FindObjectOfType<Spawn1>();
        tr1 = GameObject.FindObjectOfType<Spawn>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovePlayer.rightmov =!(MovePlayer.rightmov);
        float temp=collision.gameObject.transform.localScale.x;
        collision.gameObject.transform.localScale = new Vector3(-temp, collision.gameObject.transform.localScale.y, collision.gameObject.transform.localScale.z);
        Score.score++;
        tr2.enabled = true;
        tr1.enabled = false;
    }
}
