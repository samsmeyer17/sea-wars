using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

    [Header("General")]
    [Tooltip("In ms^-1")] [SerializeField] float ControlSpeed = 20f;
    [Tooltip("In m")] [SerializeField] float xRange = 5f;
    [Tooltip("In m")] [SerializeField] float yRange = 5f;

    [Header("Screen-Position")]
    [SerializeField] float positionPitchFactor = -2.5f;
    [SerializeField] float positionYawFactor = 5f;

    [Header("Control-Throw")]
    [SerializeField] float controlPitchFactor = -20f;
    [SerializeField] float controlRollFactor = -50f;


    float xThrow, yThrow;
    
    bool ControlsEnabled = true;
    

    // Update is called once per frame
    void Update()
    {
        if (ControlsEnabled)
        {
            MovementHandler();
            ProcessRotation();
        }
        
    }

    void OnPlayerDeath() // called by string-reference. rename string as well.
    {
        ControlsEnabled = false;

    } 

    void ProcessRotation()
    {
        float controlThrowPitch = yThrow * controlPitchFactor;
        float positionPitch = transform.localPosition.y * positionPitchFactor;
        float pitch = positionPitch + controlThrowPitch;

        float positionYaw = transform.localPosition.x * positionYawFactor;
        float yaw = positionYaw;

        float controlThrowRoll = xThrow * controlRollFactor;
        float roll = controlThrowRoll;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    void MovementHandler()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = (xThrow) * ControlSpeed * Time.deltaTime;
        float rawNewXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawNewXPos, -xRange, xRange);

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = (yThrow) * ControlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }

    
}


