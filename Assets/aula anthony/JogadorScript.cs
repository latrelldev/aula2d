using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class JogadorScript : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");

        float directionY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(directionX, directionY);
    }

    void FixedUpdate()
    {
       rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

        
    }
}
