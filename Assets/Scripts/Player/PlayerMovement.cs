using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    private Vector2 _smoothMovement;
    private Vector2 _smoothVelocity;
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateDirection();
    }

    private void SetPlayerVelocity()
    {
        _smoothMovement = Vector2.SmoothDamp(_smoothMovement, _movementInput, ref _smoothVelocity, 0.1f);

        _rigidbody.velocity = _smoothMovement * _speed;
    }

    private void RotateDirection()
    {
        if(_movementInput != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _smoothMovement);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
            _rigidbody.MoveRotation(rotation);
        }
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
