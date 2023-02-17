using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DopplerEffect : MonoBehaviour
{
    public Transform listener;
    public float speedOfSound = 343f;

    const float moveUnitsPerSecond = 5f;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        #region Keyboard movement
        Vector3 position = transform.position;

        // Get new horizontal position
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * moveUnitsPerSecond * Time.deltaTime;
        }

        // Get new vertical position
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            position.y += verticalInput * moveUnitsPerSecond * Time.deltaTime;
        }

        // Move the character
        transform.position = position;
        #endregion
    }

    private void FixedUpdate()
    {
        // Calculate relative velocity between listener and audio source
        Vector3 relativeVelocity = listener.GetComponent<Rigidbody2D>().velocity - GetComponent<Rigidbody2D>().velocity;
        float relativeSpeed = Vector3.Dot(relativeVelocity, transform.forward);

        // Calculate pitch shift based on relative velocity
        float pitchShift = (speedOfSound + relativeSpeed) / speedOfSound;

        // Set pitch property of audio source
        audioSource.pitch = pitchShift;
    }
}
