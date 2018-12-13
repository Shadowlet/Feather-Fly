﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private float timer = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Destroy(this.gameObject);
        }

	}

    private void OnDisable()
    {
        CancelInvoke("Shooting");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
    }
}
