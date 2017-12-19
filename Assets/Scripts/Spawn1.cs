using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    public GameObject spike;
    int noofspikes,noofobjects,flag;
    List<int> store = new List<int>();
    // Use this for initialization
    void Start()
    {
        noofobjects = 0;
        flag = 0;
        
    }

    private void OnEnable()
    {
        //if (noofobjects < noofspikes && noofobjects != 0)
            foreach (Transform child in transform)
            {
                foreach (Transform child2 in child)
                {
                    Destroy(child2.gameObject);
                }
            }
            flag = 0;
            noofobjects = 0;
        if (Score.score <= 5)
            noofspikes = 3;
        if (Score.score > 5 && Score.score <= 25)
            noofspikes = 4;
        if (Score.score > 25 && Score.score <= 45)
            noofspikes = 5;
        if (Score.score > 45)
            noofspikes = 6;
        /*if (Score.score > 35 && Score.score <= 45)
            noofspikes = 7;
        if (Score.score > 45)
            noofspikes = 8;*/
        randomenemy();

    }
    void randomenemy()
    {
        if (noofobjects == noofspikes)
        { flag = 1; }
        if (noofobjects < noofspikes && noofobjects != 0)
        {
            foreach (Transform child in transform)
            {
                foreach (Transform child2 in child)
                {
                    Destroy(child2.gameObject);
                }
            }
            flag = 0;
            noofobjects = 0;
        }
        if (flag == 0)
        {
            for (int i = 0; i < noofspikes; i++)
            {
                while (true)
                {
                    System.Random rnd = new System.Random();
                    int temp = rnd.Next(1, 13);
                    store.Add(temp);
                    Debug.Log(temp);
                    int count = 0;
                    int flag = 0;
                    foreach (Transform child in transform)
                    {
                        count++;
                        if (count == temp && child.childCount == 0)
                        {
                            GameObject spikelol = Instantiate(spike, child.transform.position, Quaternion.Euler(0, 0, 270f)) as GameObject;
                            spikelol.transform.parent = child;
                            flag = 1;
                            noofobjects++;
                        }
                        if (flag == 1)
                            break;
                    }
                    if (flag == 1)
                        break;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
