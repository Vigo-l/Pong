using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    //the speed that the pallet goes up and down
    public float ySpeed = 5f;
    // keeps it on the same y position
    public float yPosition = 0f;

    // Update is called once per frame
    void Update()
    {

        // makes it so that the pallet runs on real time and not frames so its the same speed on all devices
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
      //makes it so that it cant go further than the walls
        if (yPosition >= 11.3)
        {
            ySpeed = ySpeed * -1f;
        } else if (yPosition <= -3.6f){
            ySpeed = ySpeed * -1f;
        }
    }
}
