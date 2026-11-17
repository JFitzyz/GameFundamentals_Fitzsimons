using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerMovement movement;
    float timer = 2;
    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        movement.moveInput = Vector2.left;
    }
    void Update()
    {
        timer = timer -= Time.deltaTime;

        if (timer < 0)
        {
            movement.moveInput *= -1;
            timer = 2;
        }
        if (movement.isJumpRequested == false)
        {
            movement.Jump();
        }
    }
}
