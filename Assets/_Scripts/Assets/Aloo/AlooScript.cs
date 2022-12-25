using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlooScript : MonoBehaviour {
    public Rigidbody2D rigidBody2d;

    public float jumpVelocity = 1.6f;

    public Animator animator;

    private bool canFly = true;
    
    private LogicManager logicManager;
    
    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
        rigidBody2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") && canFly)
        {
            rigidBody2d.velocity = Vector2.up * jumpVelocity;
            animator.SetBool("isGoingUp", true);
        }
        else if(Input.GetKeyDown("down") && canFly)
        {
            rigidBody2d.velocity = Vector2.up * -jumpVelocity;
            animator.SetBool("isGoingUp", false);
        }
        else
        {
            animator.SetBool("isGoingUp", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 3)
        {
            canFly = false;
            logicManager.IsGameOver = true;
        }
    }
}