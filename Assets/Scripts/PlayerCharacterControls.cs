using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterControls : MonoBehaviour
{
    public Spawner gun = null;

    InputAction attackAction;
    InputAction aimAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        aimAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 aimValue = aimAction.ReadValue<Vector2>();
        gun.transform.right = aimValue;

        gun.isSpawning = attackAction.IsPressed(); // gun.IsSpawning match attackAction.IsPressed

        Debug.DrawRay(gun.transform.position, attackAction.ReadValue<Vector2>());
    }
}
