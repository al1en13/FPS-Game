using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;

    private PlayerInput.PlayerActions playerAction;

    private PlayerMovement move;

    private PlayerLook look;
    private void Awake()
    {
        playerInput = new PlayerInput();

        playerAction = playerInput.Player;

        move = GetComponent<PlayerMovement>();

        look = GetComponent<PlayerLook>();

        playerAction.Jump.performed += ctx => move.Jump();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        move.Move(playerAction.Movement.ReadValue<Vector2>());

        
    }

    private void LateUpdate()
    {
        look.Look(playerAction.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        playerAction.Enable();
    }

    private void OnDisable()
    {
        playerAction.Disable();
    }
}
