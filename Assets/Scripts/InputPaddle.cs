using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputPaddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (leftOrRight == "left")
        {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up *speed* Time.deltaTime);
            Debug.Log("W key pressed");
        } else if (Input.GetKey(KeyCode.S)) 
        { 
            transform.Translate(Vector3.down*speed*Time.deltaTime);
        }
        }
       else if (leftOrRight == "right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("uparrow key pressed");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
        
        

    }
