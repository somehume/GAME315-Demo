using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int[4];
    // Start is called before the first frame update
    void Start()
    {
        myIntArray[0] = 10;
        myIntArray[1] = 23;
        myIntArray[2] = 45;
        myIntArray[3] = 37;

        Debug.Log(myIntArray[1]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
