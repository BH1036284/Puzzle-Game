using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTilt : MonoBehaviour
{
    public float tiltAngle = 30f; // Maximum tilt angle
    public float tiltSpeed = 50f; // Speed of tilt

    float horizontalAngle;
    float verticalAngle;

    private Vector3 previousMousePosition;

    void Start()
    {
        previousMousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        // Get input from arrow keys
        float horizontalInput = (((Input.GetAxis("Mouse X") + Input.GetAxis("Horizontal")) * Time.deltaTime) * tiltSpeed);
        float verticalInput = (((Input.GetAxis("Mouse Y") + Input.GetAxis("Vertical")) * Time.deltaTime) * tiltSpeed);

        horizontalAngle = Mathf.Clamp(horizontalAngle + horizontalInput, -tiltAngle, tiltAngle);
        verticalAngle = Mathf.Clamp(verticalAngle + verticalInput, -tiltAngle, tiltAngle);

        print(horizontalAngle + ", " + verticalAngle);

        // Calculate target rotation based on input
        Quaternion targetRotation = Quaternion.Euler(
            Mathf.Clamp(verticalAngle, -tiltAngle, tiltAngle),
            0,
            Mathf.Clamp(-horizontalAngle, -tiltAngle, tiltAngle)
        );

        // Smoothly tilt towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, tiltSpeed * Time.deltaTime);
        
    }
}
