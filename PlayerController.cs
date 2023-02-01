using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private float dirX;
    private float moveSpeed = 2.5f;
    private float jumpForce = 800;
    float walkForce = 3.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        int key = 0;
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(dirX, 0f);

        float speedx = Mathf.Abs(this.rb.velocity.x);
        this.animator.speed = speedx / 2.0f;

        if (speedx < this.maxWalkSpeed)
        {
            this.rb.AddForce(transform.right * key * this.walkForce);
        }
    }

    public void Jump()
    {
        if (this.rb.velocity.y == 0)
        {
            this.rb.AddForce(transform.up * this.jumpForce);
        }
    }
}
