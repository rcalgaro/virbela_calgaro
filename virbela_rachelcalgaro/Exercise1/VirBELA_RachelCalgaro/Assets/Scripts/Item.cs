using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Item extends abstract Colorable class.
/// </summary>
public class Item : Colorable
{
    /// <summary>
    /// The color to change the Item object to when the player is closest to it.
    /// </summary>
    [SerializeField]
    public Color color = Color.red;

    /// <summary>
    /// The default color of the Item object.
    /// </summary>
    [SerializeField]
    public Color defaultColor = Color.gray;

    /// <summary>
    /// It turns out that this function does not need to be abstract, however I wanted to keep it this way to show how it would be done
    /// if this function required behavior specific to the Item.
    /// </summary>
    /// <param name="color">flag for turning the color on or off.</param>
    public override void ChangeColor(bool setColor)
    {
        var cubeRenderer = this.gameObject.GetComponent<Renderer>();
        if (cubeRenderer != null)
        {
            cubeRenderer.material.SetColor("_Color", setColor ? this.color : defaultColor);
        }
    }

}
