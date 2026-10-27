using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterControls : MonoBehaviour
{
    public Spawner gun = null;

    InputAction attackAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        gun.isSpawning = attackAction.IsPressed(); // gun.IsSpawning match attackAction.IsPressed
    }
}
