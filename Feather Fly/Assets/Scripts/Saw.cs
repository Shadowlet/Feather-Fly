using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour {
    public float spawnTimer = 3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = 3;
        }

        //Debug.Log(spawnTimer);
        if (spawnTimer <= 1)
        {
            //Debug.Log("True");
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision saw)
    {
        if(saw.gameObject.tag == "block")
        {
            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
