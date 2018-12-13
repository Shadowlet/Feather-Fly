using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public GameObject[] wayPoints;
    private int currentWayPoint = 0;
    public Rigidbody enemy;
    private float speed = .05f;
    public GameObject bullet;
    public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Shooting", 1, 1); // Name, time it takes to start, repeat rate
	}

    void Shooting ()
    {
        GameObject temp = Instantiate(bullet, this.transform.position, this.transform.rotation);
        temp.GetComponent<Rigidbody>().AddForce(Vector3.forward * 500);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x  == wayPoints[currentWayPoint].transform.position.x)
        {
            if(currentWayPoint == 0)
            {
                currentWayPoint = 1;
                transform.Rotate(new Vector3(0, 180, 0));
            }
            else
            {
                currentWayPoint = 0;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        }
		transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, speed);
	}
}
