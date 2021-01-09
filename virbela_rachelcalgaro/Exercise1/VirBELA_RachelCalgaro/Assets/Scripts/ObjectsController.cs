using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The controller script to handle the functions of this test.
/// </summary>
public class ObjectsController : MonoBehaviour
{
    [SerializeField]
    public List<Colorable> colorables;

    [SerializeField]
    public Player player;

    // Update is called once per frame
    void Update()
    {
        Colorable temp = null;
        float minDistance = Mathf.Infinity;
        foreach (Colorable c in colorables)
        {
            // Iterate through the distance between the player and each square to find the closest value.
            float distance = c.GetDistanceFromPosition(player.transform.position);
            if (distance < minDistance)
            {
                // If previous min distance but no longer, change to default color.
                if(temp != null)
                    temp.ChangeColor(false);
                temp = c;
                minDistance = distance;
            }
            else
            {
                // If not the min distance, change to default color.
                c.ChangeColor(false);
            }
        }

        // Change the closest object to be colored.
        temp.ChangeColor(true);
    }
}
