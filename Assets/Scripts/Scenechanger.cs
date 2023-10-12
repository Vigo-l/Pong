using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    public void startOnePlayer()
    {
        SceneManager.LoadScene("Assignment1");
    }
    public void startTwoPlayer()
    {
        SceneManager.LoadScene("Assignment2");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
