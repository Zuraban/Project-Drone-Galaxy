using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerH : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private InputControls _inputControls;

    private void Awake()
    {
        _inputControls = new InputControls();

        _inputControls.PlayerDrone.Attack.performed += context => OnAttack();
        
        
    }

    private void OnEnable()
    {
        _inputControls.Enable();
    }

    private void OnDisable()
    {
        _inputControls.Disable();
    }

    private void Update()
    {
        Vector2 moveDirection = _inputControls.PlayerDrone.Move.ReadValue<Vector2>();
        Move(moveDirection);
    }

    private void Move(Vector2 directionMove)
    {
        Vector3 direction = new Vector3(directionMove.x, 0, directionMove.y);
        transform.position += direction * _moveSpeed * Time.deltaTime;
    }

    private void OnAttack()
    {
        Debug.Log("Attack!");
    }

   
}
