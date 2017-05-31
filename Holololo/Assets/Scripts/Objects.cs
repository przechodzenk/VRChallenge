﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {

    public GameObject ball { get; set; }

    public GameObject target { get; set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ball != null)
        {
            if(target != null)
            {
                ball.GetComponent<BallMovement>().setTarget(target.gameObject);
            }
        }
	}
        
}