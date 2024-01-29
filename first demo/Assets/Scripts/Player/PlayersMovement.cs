using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveinput;
    public bool isFacingRight;
    void Start()
    {
        rb.gravityScale = 0;
    }


    void Update()
    {
        moveinput.x = Input.GetAxisRaw("Horizontal");
        moveinput.y = Input.GetAxisRaw("Vertical");
        moveinput.Normalize();

        rb.velocity = moveinput * moveSpeed;

        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && moveinput.x < 0f || !isFacingRight && moveinput.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }

}


