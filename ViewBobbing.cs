using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PositionFollower))]
public class ViewBobbing : MonoBehaviour
{
    public float effectIntensity;   // Intensity of the vertical bobbing effect
    public float effectIntensityX;  // Intensity of the horizontal bobbing effect
    public float effectSpeed;       // Speed at which the bobbing effect occurs

    private PositionFollower followerinstance;  // Reference to the PositionFollower component
    private Vector3 originalOffset;              // Original offset of the position follower
    private float sinTime;                       // Time value for the sine wave calculation

    void Start()
    {
        followerinstance = GetComponent<PositionFollower>();  // Get the PositionFollower component attached to this game object
        originalOffset = followerinstance.offset;             // Store the original offset of the position follower
    }

    void Update()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));
        // Get the input vector representing player movement in the vertical and horizontal axes

        if (inputVector.magnitude > 0f)
        {
            sinTime += Time.deltaTime * effectSpeed;
            // If there is player input (movement is not zero), increment the sinTime based on time and effect speed
        }
        else
        {
            sinTime = 0f;
            // If there is no player input (movement is zero), reset the sinTime to zero
        }

        float sinAmountY = -Mathf.Abs(effectIntensity * Mathf.Sin(sinTime));
        // Calculate the vertical bobbing amount using the effect intensity and sine function

        Vector3 sinAmountX = followerinstance.transform.right * effectIntensity * Mathf.Cos(sinTime) * effectIntensityX;
        // Calculate the horizontal bobbing amount using the effect intensity, cosine function, and right direction of the position follower

        followerinstance.offset = new Vector3()
        {
            x = originalOffset.x,
            y = originalOffset.y + sinAmountY,
            z = originalOffset.z
        };
        // Update the position follower's offset by modifying the y component with the vertical bobbing amount

        followerinstance.offset += sinAmountX;
        // Update the position follower's offset by adding the horizontal bobbing amount
    }
}
