using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPaddle : MonoBehaviour
{
    public float speed = 10f;
    public string leftOrRight;

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            if (Input.GetKey(KeyCode.W))
            {
                MovePaddle(Vector3.up);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                MovePaddle(Vector3.down);
            }
        }
        else if (leftOrRight == "right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                MovePaddle(Vector3.up);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                MovePaddle(Vector3.down);
            }
        }
    }

    private void MovePaddle(Vector3 direction)
    {
        // this is for the paddles new position
        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

        // this is for the paddle to stay whitin the area
        float minY = -3.5f; 
        float maxY = 9.5f; 

        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // this updates the paddles position
        transform.position = newPosition;
    }
}
