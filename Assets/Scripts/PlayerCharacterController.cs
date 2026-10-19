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
    InputAction attackAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        // spawner.isSpawning = attackAction.IsPressed();
    }
}
