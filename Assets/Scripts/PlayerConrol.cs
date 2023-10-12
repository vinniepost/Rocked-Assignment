using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float boostForce = 1f;
    public float tiltSpeed = 1f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the tilt angle based on input
        float targetTiltAngle = horizontalInput * tiltSpeed;

        // Apply the tilt as an offset to the current rotation
        Quaternion tiltRotation = Quaternion.Euler(0f, 0f, targetTiltAngle);
        rb.rotation *= tiltRotation;

        if (isGrounded)
        {
            rb.rotation *= Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            // Apply upward force relative to the rocket ship's orientation
            rb.AddRelativeForce(Vector3.up * boostForce, ForceMode.Impulse);
        }
    }
}

