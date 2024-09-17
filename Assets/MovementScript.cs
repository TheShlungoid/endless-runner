using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;            // Speed
    public float jumpForce = 10f;           // Jump
    public Transform groundCheckPoint;      // point to check if player is grounded
    public float checkRadius = 0.2f;        // Radius for overlap circle for ground detect
    public LayerMask groundLayer;           // Layer of ground objects

    private Rigidbody2D rb;                 // referenced Rigidbody component
    private bool isGrounded;                // variable if player is grounded or not

    //audio section
    public AudioClip jump;
    public AudioClip backgroundMusic;

    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //get Rigidbody attached to player
    }

    // Update is called once per frame
    void Update()
    {
        //Constant forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // check if player is groundded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        //Jumping Logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {

            Jump();
        }
    }


    private void Jump()
    {
        // add upward force to jump
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        //Draw circle to visualise ground check collider
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }


}

