using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public int jumpSpeed;
    public int moveSpeed;
    public LayerMask groundMask;
    private bool canDoubleJump;

    public int rotateDegrees;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1, groundMask);
        Debug.DrawRay(transform.position, new Vector3(0, -1, 0));

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        }

        if (Input.GetKey(KeyCode.E)){

            transform.eulerAngles += Vector3.forward * -rotateDegrees;

        } else  if (Input.GetKey(KeyCode.Q)){

            transform.eulerAngles += Vector3.forward * rotateDegrees;

        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (hit.collider != null && hit.collider.tag == "Ground")
            {
                rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
                canDoubleJump = true;
            }
            else if(canDoubleJump)
            {
                rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
                canDoubleJump = false;
            }
        }
    }
}
