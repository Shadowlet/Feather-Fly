using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//-------NOTE TO SELF!!!!---------//

// * Remove velocity garbage
public class Player : MonoBehaviour {
    //public GameManager gameManager;
    public Camera featherCamera;
    public Rigidbody feather;
    private float XVelocity = 0;
    private float YVelocity = 0;
    private float maxSpeedRight = 4;
    private float maxSpeedLeft = -8;
    bool fanOn = false;
    bool featherFlying;
        





    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        feather.AddForce(Vector3.right * 100);


        // Check key presses for fans every frame
        if (Input.GetKey(KeyCode.A))
        {
            fanOn = true;
        
            fanLeft(); // Run fan logic
            
            if(Mathf.Abs(XVelocity) > maxSpeedRight)
            {
                XVelocity = maxSpeedRight -= 1;

            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            fanOn = true;
            fanBottom(); // Run fan logic
            //feather.velocity = (new Vector3(XVelocity, YVelocity, 1));

            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            fanOn = true;
            fanRight(); // Run fan logic

            if (Mathf.Abs(XVelocity) > maxSpeedLeft)
            {
                XVelocity = maxSpeedLeft += 1;

            }
        }

        else
        {
            fanOn = false;
            Debug.Log(fanOn);
        }



    }



    private void fanLeft()
    {
        // Logic for the left fan blowing  

        if (fanOn == true)
        {
            feather.AddForce(Vector3.right * 750);
        }
        else
        {
            fanOn = false; // turn off fan
        }

    }

    private void fanBottom()
    {
        fanOn = true;
        // Logic for the bottom fan blowing

        if (fanOn == true)
        {
            feather.AddForce(Vector3.up * 1000); // <----

           

        }
        else
        {
            fanOn = false; // turn off fan
        }

    }

    private void fanRight()
    {
        fanOn = true;
        // Logic for the right fan blowing

        if(fanOn == true)
        {

            feather.AddForce(Vector3.left * 750);

        }
        else
        {
            fanOn = false; // turn off fan
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag)
    }

    public void gameOver(int status)
    {
        // collision stuff
    }

}
