using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterControls : MonoBehaviour
{
    public Spawner gun = null;
    public PlayerMovement movement;

    InputAction attackAction;
    InputAction moveAimAction;
    InputAction jumpAction;
    InputAction aimAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        moveAimAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        gun.isSpawning = attackAction.IsPressed();
        Vector2 moveAimValue = moveAimAction.ReadValue<Vector2>();
        gun.transform.right = moveAimValue;

        movement.moveInput = moveAimValue;
        if (jumpAction.WasPressedThisFrame())
        {
            movement.isJumpRequested = true;
        }

    }
}
