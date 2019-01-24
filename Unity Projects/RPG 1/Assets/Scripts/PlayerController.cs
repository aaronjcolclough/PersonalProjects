using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidBody = GetComponent<Rigidbody2D>();

        if (Input.anyKey)
        {
            if (Input.GetKey("right"))
            {
                animator.SetTrigger("WalkRight");
                rigidBody.velocity = new Vector2(3, rigidBody.velocity.y);
            }

            if (Input.GetKey("left"))
            {
                animator.SetTrigger("WalkLeft");
                rigidBody.velocity = new Vector2(-3, rigidBody.velocity.y);
            }

            if (Input.GetKey("up"))
            {
                animator.SetTrigger("WalkUp");
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, 3);
            }

            if (Input.GetKey("down"))
            {
                animator.SetTrigger("WalkDown");
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, -3);
            }
        }

        else
            animator.SetTrigger("NoKey");
    }
}
