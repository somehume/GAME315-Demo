using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) //only works with 15
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0) //only works with 3
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0) //only works with 5
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i); //counts out all mubers but divisibles of 3 & 5 (except 3, 5, & 15) are missing, no idea why 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
