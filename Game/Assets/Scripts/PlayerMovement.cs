using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Speed variables
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    private bool isSprinting = false;

    // Dash variables
    public float dashSpeed = 20f;
    public float dashDuration = 0.2f;
    private bool isDashing = false;
    private float dashTime;

    // Rigidbody2D component
    private Rigidbody2D rb;

    // Movement vector
    private Vector2 movement;

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from keyboard for regular movement
        if (!isDashing)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }

        // Check for dash input
        if (Input.GetKeyDown(KeyCode.Space) && !isDashing)
        {
            StartDash();
        }

        // Toggle sprint mode
        if (Input.GetKeyDown(KeyCode.E))
        {
            isSprinting = !isSprinting;
        }
    }

    void FixedUpdate()
    {
        if (isDashing)
        {
            Dash();
        }
        else
        {
            Move();
        }
    }

    void Move()
    {
        // Apply the movement to the Rigidbody2D
        float currentSpeed = isSprinting ? sprintSpeed : moveSpeed;
        rb.MovePosition(rb.position + movement * currentSpeed * Time.fixedDeltaTime);
    }

    void StartDash()
    {
        // Set the dashing flag and the dash timer
        isDashing = true;
        dashTime = dashDuration;

        // Get the mouse position in world coordinates
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction from the player to the mouse position
        movement = (mousePosition - rb.position).normalized;
    }

    void Dash()
    {
        if (dashTime > 0)
        {
            // Continue dashing
            rb.MovePosition(rb.position + movement * dashSpeed * Time.fixedDeltaTime);
            dashTime -= Time.fixedDeltaTime;
        }
        else
        {
            // End the dash
            isDashing = false;
            movement = Vector2.zero;
        }
    }
}
