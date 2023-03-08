using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello_World : MonoBehaviour
{
    public string printText;
    public int health;
    void Start()
    {
        Debug.Log(printText);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
            Debug.Log("Current Health:" + health.ToString());
        }


    }
}
