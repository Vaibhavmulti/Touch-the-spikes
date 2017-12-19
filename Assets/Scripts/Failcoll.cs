using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failcoll : MonoBehaviour {
    public LevelManager manage;
	// Use this for initialization1
	void Start () {
        manage = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        manage.Loadlevel("Lose");
    }
}
