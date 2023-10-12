using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float ySpeed = 5f;
    public float yPosition = 0f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / ySpeed, transform.position.z);
        /*  yPosition = yPosition + ySpeed * Time.deltaTime;
         transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
         if (yPosition >= 9.5)
         {
             ySpeed = ySpeed * -1f;
         } else if (yPosition <= -3.6f){
             ySpeed = ySpeed * -1f;
         }*/

    }
}
