using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlooScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2d;

    public float jumpVelocity = 1.25f;
    
    // Start is called before the first frame update
    void Start() {
        rigidBody2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space")) {
            rigidBody2d.velocity = Vector2.up * jumpVelocity;
        }
    }
}
