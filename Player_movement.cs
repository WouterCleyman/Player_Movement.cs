﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
	}

    void FixedUpdate()
    {
        //move character
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
