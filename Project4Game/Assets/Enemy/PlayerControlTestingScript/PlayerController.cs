
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;


    public void Update()
    {
        ProcessInputs();
    }

    public void FixedUpdate()
    {
        Move();
    }

    public void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical"); ;

        moveDirection = new Vector2(moveX, moveY);
    }
    public void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }
}
