using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls player movement using input axes and Rigidbody2D physics.
/// </summary>
public class Player : MonoBehaviour
{
    /// <summary>
    /// The Rigidbody2D component attached to the player.
    /// </summary>
    private Rigidbody2D rb;

    /// <summary>
    /// Movement speed of the player.
    /// </summary>
    [SerializeField] private float playerSpeed = 50f;

    /// <summary>
    /// Stores player movement input as a normalized vector.
    /// </summary>
    private Vector2 movement;

    /// <summary>
    /// Initializes the Rigidbody2D component.
    /// </summary>
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Captures player input each frame and updates the movement vector.
    /// </summary>
    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    /// <summary>
    /// Applies physics-based movement at fixed intervals.
    /// </summary>
    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    /// <summary>
    /// Moves the player based on direction and speed using Rigidbody2D physics.
    /// </summary>
    /// <param name="direction">Normalized movement direction.</param>
    private void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * playerSpeed * Time.deltaTime));
    }
}