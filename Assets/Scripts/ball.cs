using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
   /// <summary>
   /// settings for the ball
   /// - move in x and y directions
   /// - change course when hitting the wall
   /// - when ball hits the paddle it speeds up
   /// - when it hits the left or right wall change score
   /// - showing the score
   /// </summary>
    
    // the speed and start position of the ball
    public float Xposition = 1f;
    public float Yposition = 1f;
    public float xSpeed;
    public float ySpeed;
   // refrence to the score text
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
   // stops the game if the score is met
    private int topScore = 10;

   //Function for resets the ball to start position and adds the score to left or right
    private void resetBall(string leftOrRight)
    {
        //starting positions for x and y
        Xposition = 0f;
        Yposition = 0f;
        // displays the score in the text ield
        scoreField.text = leftScore + " - " + rightScore;
       
        //checks if the ball hit left or right
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
        // sets the ball to the start position
        transform.position = new Vector3(Xposition, Yposition, 0);
        xSpeed = 3f;
        ySpeed = 3f;
    }


    // Update is called once per frame
    void Update()
    {
        // makes it so that the ball runs on real time and not frames so its the same speed on all devices
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        // makes it so that if the topscore is reached the game stops
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
        //makes it so that the ball bounces of walla
        if (collision.gameObject.CompareTag("horizontalwall"))

        {
            ySpeed = ySpeed * -1f;
            Debug.Log("raakt horizontal aan");
        }
      // adds points to the score
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