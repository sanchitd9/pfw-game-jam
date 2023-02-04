using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float speed = 8f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform collisionCheck;
    [SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetbuttonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if(Input.GetbuttonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void fixedUpdate()
    {
        rb.velocity = new Vector2(horizontal*speed, rb.velocity.y);
    }

    private bool isGrounded() 
    {
        return Physics2D.OverlapCircle(collisionCheck.position, 0.2f, groundLayer);
    }
}
