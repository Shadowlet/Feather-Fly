using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//-------NOTE TO SELF!!!!---------//
// ** Full feather distance = 166.18939 x
// ** Half feather distance = 83.094695 x

public class Player : MonoBehaviour {
    //public GameManager gameManager;
    public Camera featherCamera;
    public Rigidbody feather;
    
    public float featherX;
    public float featherY;
    public float gameDistance = 166;
    public bool inVacuum = false;
    public bool inFan = false;


    public GameManager gameManager;

    // Use this for initialization
    void Start() {
        

        featherX = feather.transform.position.x;
        featherY = feather.transform.position.y;

        //player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        // Feather automatically moving right
        feather.AddForce(Vector3.right * 280);

        // Fan shit
        if(inFan == true)
        {
            feather.AddForce(Vector3.left * 1600);
        }
        else
        {
            inFan = false;
        }

        // Vacuum shit
        if(inVacuum == true)
        {
            feather.AddForce(Vector3.right * 1300);
        }
        else
        {
            inVacuum = false;
        }



        // Blows feather 
        if (Input.GetKey(KeyCode.S))
        {
            feather.AddForce(Vector3.up * 1000); // <----
        }

        // YOU WIN
        if(feather.transform.position.x >= 150)
        {
            gameManager.game.SetActive(false);
            gameManager.deathScreen.SetActive(true);
            enabled = false;
            // Winning screen //
        }


    }

    // Wind related blocks
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vacuumArea")
        {
            inVacuum = true;
            Debug.Log("Vacuum True");
        }
        if (other.gameObject.tag == "fanArea")
        {
            inFan = true;
            Debug.Log("Fan True");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "vacuumArea")
        {
            inVacuum = false;
            Debug.Log("Vacuum False");
        }
        if (other.gameObject.tag == "fanArea")
        {
            inFan = false;
            Debug.Log("Fan False");
        }
    }
    private void OnCollisionEnter(Collision anything)
    {
        if (anything.gameObject.tag == "block" || anything.gameObject.tag == "saw")
        {
            gameManager.DeathScreen();
        }
    }

    private void OnCollisionExit(Collision windBox)
    {
        
    }

    public void gameOver(int status)
    {
        // collision stuff
    }


}
