using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCannon : MonoBehaviour {
    public GameObject saw;
    //public Transform sawSpawn;
    //public float sawSpeed = 0.5f;




    // Use this for initialization
    private void Start () {
        InvokeRepeating("shootSaw", 1, 1);

	}
	

    void shootSaw()
    {
        GameObject tempSaw = Instantiate(saw, this.transform.position, this.transform.rotation);
        tempSaw.GetComponent<Rigidbody>().AddForce(Vector3.left * 6000);

        //Debug.Log(saw.transform.position.y);



    }
    // OnCollisionEnter instead. Make saw spawn right outside of cannon so that they don't collide.
    private void OnCollisionExit(Collision saws)
    {
        // When colliding with blocks, destroy saws
    }

    private void Update()
    {

        
    }

}  
