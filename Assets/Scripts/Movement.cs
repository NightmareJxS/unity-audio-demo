using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    const float moveUnitsPerSecond = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
