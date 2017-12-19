using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBottomwall : MonoBehaviour {
    LevelManager manage;
    private void Start()
    {
        manage = GameObject.FindObjectOfType<LevelManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        manage.Loadlevel("Lose");
    }
}
