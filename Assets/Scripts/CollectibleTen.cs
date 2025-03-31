using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleTen : MonoBehaviour
{
    public static int activeCount = 0;

    void OnEnable()
    {
        activeCount++;
    }

    void OnDestroy()
    {
        activeCount--;
    }

    void OnMouseDown()
    {
        GameManagerTen.AddScore();
        Destroy(gameObject);
    }
}