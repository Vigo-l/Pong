using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPaddle1 : MonoBehaviour
{
    public float speed = 10f;
    public string leftOrRight;

    private bool isMovingUp = false; // Track whether the paddle is moving up or down

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            // Toggle the direction when the W key is pressed
            if (Input.GetKeyDown(KeyCode.W))
            {
                isMovingUp = !isMovingUp;
            }
        }
        else if (leftOrRight == "right")
        {
            // Toggle the direction when the UpArrow key is pressed
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                isMovingUp = !isMovingUp;
            }
        }

        // Move the paddle based on the current direction
        if (isMovingUp)
        {
            MovePaddle(Vector3.up);
        }
        else
        {
            MovePaddle(Vector3.down);
        }
    }

    private void MovePaddle(Vector3 direction)
    {
        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;
        float minY = -3.5f;
        float maxY = 3.5f;
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }
}
