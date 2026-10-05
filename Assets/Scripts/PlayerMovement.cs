using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // These variables are to hold the Action references

    //Movement speed in m/s
    public float moveSpeed = 5f;
    public float jumpSpeed = 6f;
    public bool isGrounded;
    public Rigidbody2D rb;

    InputAction moveAction;
    InputAction jumpAction;

    private void Start()
    {
        // Get reference to the RigidBody2D component attached to this game object
        rb = GetComponent<Rigidbody2D>();
        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    void Update()
    {
        // Read the "Move" action value, which is a 2D vector
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        // your movement code here
        //transform.Translate(new Vector3(moveValue.x, moveValue.y * 0.01f));

        rb.linearVelocityX = moveValue.x * moveSpeed;

        if (jumpAction.WasPressedThisFrame() && isGrounded)
        {
            rb.linearVelocityY = jumpSpeed;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}