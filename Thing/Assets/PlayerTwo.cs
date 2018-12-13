using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwo : MonoBehaviour {
    public Rigidbody player;
    public bool isJumping = false;
    private float xVelocity = 0;
    private float yVelocity = 0;
    private float maxSpeed = 10;
    private float direction = 0;
    public Image[] hitPoints;
    private int hits = 2;
    public Camera mainCam;
    public Text words;
    public Text timer;
    private float time = 300;
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
        words.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            time = 0;
            // Game Over
        }

        timer.text = time.ToString("f0");

        // CONTROLS 
		if (Input.GetKey(KeyCode.W))
        { 
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            xVelocity += .5f;
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xVelocity -= .5f;
            direction = -1;
        }
        else
        {
                

        }
        if (Input.GetKey(KeyCode.S))
        {
            
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            player.AddForce(Vector3.up * 5000);
        }

        if (Mathf.Abs(xVelocity) > maxSpeed)
        {
            xVelocity = maxSpeed * direction;
        }
        
        player.velocity = new Vector3(xVelocity, player.velocity.y, 0);
        //Debug.Log(player.velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "")
        {

        }

        if(collision.gameObject.name == "bullet")
        {
            Damaged();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Floor")
        {
            isJumping = false;

        }

        if(collision.gameObject.tag == "enemy")
        {
            if(this.transform.position.y > collision.transform.position.y + 1)
            {
                Debug.Log(this.transform.position.y);
                Debug.Log("enemy " + collision.transform.position.y);
                collision.gameObject.SetActive(false);
                
            }
            else
            {
                hitPoints[hits].enabled = false;
                hits--;

                // Turn player off / kill player
                if (hits < 0)
                {
                    mainCam.transform.parent = GameObject.Find("Background").transform;
                    words.enabled = true;
                    this.gameObject.SetActive(false);
                }
            }

            
        }
    }

    private void Damaged()
    {

    }

    private void GameOver()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "door")
        {
            mainCam.transform.parent = GameObject.Find("Background").transform;
            words.text = "Good Job!";
            words.enabled = true;
            this.gameObject.SetActive(false);

            
        }
    }
}
    