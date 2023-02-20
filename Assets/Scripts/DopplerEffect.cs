using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DopplerEffect : MonoBehaviour
{
    public Transform listener;
    public float speedOfSound = 343f;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

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
