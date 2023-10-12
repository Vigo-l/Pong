using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    public float Xposition = 1f;
    public float Yposition = 1f;
    public float xSpeed;
    public float ySpeed;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    private int topScore = 10;
    public float rotationSpeed;
    private object scaling;

    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = leftScore + " - " + rightScore;
        if(leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if(leftOrRight == "right")
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);
        xSpeed = 3f;
        ySpeed = 3f;
        rotationSpeed = 10 * 360f;
    }


    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if (leftScore >= topScore)
        {
            scoreField.text = "Left player has won i have a tia";
            xSpeed = 0f;
            ySpeed = 0f;
            Yposition = 0f;
            Yposition = 0f;
        } else if(rightScore >= topScore)
        {
            scoreField.text = "Right player has won i have a tia";
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwall"))
        {
            ySpeed = ySpeed * -1f;
            Debug.Log("raakt horizontal aan");
        }
        if (collision.gameObject.CompareTag("leftWall"))
        {
            rightScore++;
            resetBall("left");
  
        }
        if (collision.gameObject.CompareTag("rightWall"))
        {
            leftScore++;
            resetBall("right");
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.5f;
            
        }
    }
}