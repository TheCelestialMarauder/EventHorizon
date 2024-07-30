using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public Transform gunTransform; // Reference to the gun's transform

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Calculate the direction from the player to the mouse position
        Vector2 direction = (mousePosition - transform.position).normalized;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the player
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // Apply the same rotation to the gun (if it's not already a child and following the player)
        if (gunTransform != null)
        {
            gunTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}
