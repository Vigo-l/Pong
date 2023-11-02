using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
   // changes the scene
    public void startOnePlayer()
    {
        SceneManager.LoadScene("Assignment1");
    }
    public void startTwoPlayer()
    {
        SceneManager.LoadScene("Assignment2");
    }
    public void startOnePlayern()
    {
        SceneManager.LoadScene("Oneplayer boring");
    }
    public void startTwoPlayern()
    {
        SceneManager.LoadScene("Twoplayer boring");
    }
    public void home()
    {
        SceneManager.LoadScene("menu");
    }
}