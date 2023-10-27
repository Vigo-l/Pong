using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public void startOnePlayer()
    {
        SceneManager.LoadScene("Assignment1");
    }
    public void startTwoPlayer()
    {
        SceneManager.LoadScene("Assignment2");
    }
}