using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float Xposition = 1f;
    public float Yposition = 1f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 2f;
        ySpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwall"))
        {
            ySpeed  = ySpeed * -1;
            Debug.Log("raakt horizontal aan");
        }
        if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1;
            Debug.Log("raakt vertical aan");
        }
        if (collision.gameObject.CompareTag("paddleLeft"))
        {
            xSpeed = xSpeed * -1;
            ySpeed += ySpeed + 1;
            Debug.Log("raakt horizontal aan");
        }
        if (collision.gameObject.CompareTag("paddleRight"))
        {
            xSpeed = xSpeed * -1;
            ySpeed += ySpeed + 1;
            Debug.Log("raakt vertical aan");
        }
    }
}