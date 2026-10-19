//Responsible for taking input for player axtions such as:
// Aiming, Shooting
// Jumping, Running
// Not actually responsible for moving or shooting, but just getting the inputs
// Classes teal color
// Public means it's accessible to other code

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : MonoBehaviour
{
    public Spawner spawner;
    InputAction moveAction;
    InputAction jumpAction;
    InputAction attackAction;
    

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        
    }

    // Update is called once per frame
    void Update()
    {
        // spawner.isSpawning = attackAction.IsPressed();

        // Use MoveAction for aiming our projectiles
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        spawner.transform.right = moveValue; // Rotate the spawner to face the direction of input.
        Debug.DrawRay(spawner.transform.position, moveValue);
    }
}
