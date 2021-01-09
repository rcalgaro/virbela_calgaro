using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The abstract class Colorable that is an object that can change color. I made this abstract because in reading the beginning of the instructions,
/// I thought having the colors and ChangeColor function abstract would make sense, since they would be different for each child. However,
/// that is not needed once the color is able to be set in the scene view. It would have made more sense potentially to create a Colorable class with property options
/// of Bot or Item, a selection of colors, and whatever other needed properties. Then each could be set up in the scene before running, and a default could be added during runtime as needed.
/// </summary>
public abstract class Colorable: MonoBehaviour
{
    /// <summary>
    /// Function to change the object to the class specific color.
    /// </summary>
    /// <param name="highlight">Whether the color is used or the default color</param>
    public abstract void ChangeColor(bool setColor);

    /// <summary>
    /// Function to determine the distance from the object in space, to the specified position.
    /// </summary>
    /// <param name="position">The comparing position</param>
    /// <returns></returns>
    public float GetDistanceFromPosition(Vector3 position)
    {
        Vector3 currentPosition = transform.position;
        float distance = Vector3.Distance(position, currentPosition);
        return distance;
    }
}
