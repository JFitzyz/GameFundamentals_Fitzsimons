using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    // These variables are to hold the Action references

    //Movement speed in m/s
    public float moveSpeed = 5f;
    public float jumpSpeed = 6f;
    public bool isGrounded = false;
    public Rigidbody2D rb;
    public Vector2 moveInput;
    public bool isJumpRequested = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocityX = moveInput.x * moveSpeed;
        if (isJumpRequested)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rb.linearVelocityY = jumpSpeed;
            isJumpRequested = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}