using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D rb;
    public float runPlayer = 3;
    public float jumPlayer = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")|| Input.GetKey("right"))
        {
            rb.velocity = new Vector2(runPlayer, rb.velocity.y);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-runPlayer, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumPlayer);

        }

    }
}
