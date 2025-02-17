using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is a log message!");
    }

    // Update is called once per frame
    void Update()
    {
        Int32 thing = 2;
        thing += 1;
        Debug.Log(thing);

    }
}
