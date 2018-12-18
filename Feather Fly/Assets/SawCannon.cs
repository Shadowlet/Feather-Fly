using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCannon : MonoBehaviour {
    public GameObject saw;
    public Transform sawSpawn;
    public float sawSpeed = 0.5f;



	// Use this for initialization
	void Start () {
        InvokeRepeating("shootSaw", 1, 1);

	}
	

    void shootSaw()
    {
        GameObject temp = Instantiate(saw, this.transform.position, this.transform.rotation);
        temp.GetComponent<Rigidbody>().AddForce(Vector3.left * 9700);

        //Time.deltaTime = 300;
    }

    private void OnCollisionEnter(Collision collide)
    {
        // Feather
        if (collide.gameObject.tag == "feather")
        {
            // end game
        }

        // Saw
        if (collide.gameObject.tag == "saw")
        {
            Destroy(collide.gameObject);
        }

        // Floating Stuff
        if (collide.gameObject.tag == "stuff")
        {
            // move other way
        }
    }

    void Update()
    {
        
    }

}  
