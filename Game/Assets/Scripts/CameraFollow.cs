using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // How smoothly the camera follows the player
    public Vector3 offset; // Offset position of the camera relative to the player

    private void LateUpdate()
    {
        if (player == null)
        {
            return; // Exit if no player is assigned
        }

        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}

