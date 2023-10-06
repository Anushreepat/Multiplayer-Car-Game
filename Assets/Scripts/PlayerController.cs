using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Multiplayer Variables.
    public string inputID;

    // Camera Switch variables.
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode keySwitch;

    // Private Variables.
    private float speed = 10.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Player Input.
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        //We make the vehicle move.
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We make the vehicle turn.
        transform.Rotate(UnityEngine.Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        // Camera switch.
        if (Input.GetKeyDown(keySwitch))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
