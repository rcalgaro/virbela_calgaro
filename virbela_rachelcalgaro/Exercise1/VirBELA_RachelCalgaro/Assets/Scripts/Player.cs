using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The script to move the player object throughout the scene. I implemented this to accept the arrow key inputs to move, before
/// realizing that the instructions said to make it movable within the scene view. It is still movable that way, but since I already
/// implemented the RigidBody I figured it would be fine to keep it in.
/// </summary>
public class Player: MonoBehaviour
{
    /// <summary>
    /// The Rigidbody used to move the player object.
    /// </summary>
    [SerializeField]
    public Rigidbody body;

    /// <summary>
    /// The speed at which the Rigidbody will move
    /// </summary>
    [SerializeField]
    public float speed;

    public void Update()
    {
        // Get horizontal and vertical movement from arrow key inputs
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        // Determine movement vector and update Rigidbody position accordingly
        Vector3 tempVect = new Vector3(horizontalMovement, 0, verticalMovement);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        body.MovePosition(transform.position + tempVect);
    }
}
