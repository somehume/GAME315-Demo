using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Automatically destroys the GameObject this script is attached to after a set amount of time.
/// </summary>
public class Destroy : MonoBehaviour
{
    /// <summary>
    /// Time in seconds before the GameObject is destroyed.
    /// </summary>
    [SerializeField] private float timeToDestroy = 5f;

    /// <summary>
    /// Called on the frame when the script is enabled. Schedules the GameObject to be destroyed.
    /// </summary>
    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    /// <summary>
    /// Called once per frame. Not currently used in this script.
    /// </summary>
    private void Update()
    {
        // No update logic required
    }
}