using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Normal movement speed
    public float sprintSpeed = 8f; // Sprinting speed
    public Transform gunTransform; // Reference to the gun's transform
    public GameObject bulletPrefab; // Prefab for the bullet
    public Transform bulletSpawnPoint; // Where the bullet will spawn
    public float bulletSpeed = 10f; // Speed of the bullet
    public float dashSpeed = 20f; // Speed during dash
    public float dashDuration = 0.2f; // Duration of the dash
    public float dashCooldown = 1f; // Cooldown time between dashes

    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 mousePos;
    private bool isDashing = false;
    private float dashTime = 0f;
    private float lastDashTime = 0f;
    private bool isSprinting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get movement input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Get mouse position in world coordinates
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Handle shooting
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        // Handle dashing
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastDashTime + dashCooldown)
        {
            StartDash();
        }

        // Manage dash duration
        if (isDashing)
        {
            dashTime -= Time.deltaTime;
            if (dashTime <= 0)
            {
                EndDash();
            }
        }

        // Handle sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }
    }

    void FixedUpdate()
    {
        float currentSpeed = isSprinting ? sprintSpeed : moveSpeed;

        if (isDashing)
        {
            // During the dash, move the player in the dash direction
            rb.MovePosition(rb.position + (Vector2)gunTransform.up * dashSpeed * Time.fixedDeltaTime);
        }
        else
        {
            // Normal movement, adjust speed if sprinting
            rb.MovePosition(rb.position + movement * currentSpeed * Time.fixedDeltaTime);
        }

        // Rotate the gun towards the mouse
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        gunTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void StartDash()
    {
        isDashing = true;
        dashTime = dashDuration;
        lastDashTime = Time.time;
    }

    void EndDash()
    {
        isDashing = false;
    }

    void Shoot()
    {
        // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Pass the desired speed to the bullet so it can handle its own movement
        Bullet bulletComponent = bullet.GetComponent<Bullet>();
        if (bulletComponent != null)
        {
            bulletComponent.bulletSpeed = bulletSpeed;
        }
    }
}
