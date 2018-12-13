using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    GameObject mainCamera;
    GameObject feather;
    float XVelocity = 0;
    float YVelocity = 0;
    float maxSpeed = 0;
    bool fanOn;
    bool featherFlying;
    int currentFan;
    



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
        // Check key presses for fans every frame
        if (Input.GetKey("A"))
        {
            fanLeft(); // Run fan logic
        }
        else if (Input.GetKey("S"))
        {
            fanBottom(); // Run fan logic
        }
        else if (Input.GetKey("D"))
        {
            fanRight(); // Run fan logic
        }



    }


    private void fanLeft()
    {
        fanOn = true;
        // Logic for the left fan blowing  
    }

    private void fanBottom()
    {
        fanOn = true;
        // Logic for the bottom fan blowing
    }

    private void fanRight()
    {
        fanOn = true;
        // Logic for the right fan blowing
    }


    public void gameOver(int status)
    {
        // collision stuff
    }

}
