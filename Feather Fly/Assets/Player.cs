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


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        float featherX = feather.transform.position.x;
        float featherY = feather.transform.position.y;

        Debug.Log(featherX);

        feather.AddForce(Vector3.right * 700);



        if (Input.GetKey(KeyCode.S))
        {

            feather.AddForce(Vector3.up * 1000); // <----


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
