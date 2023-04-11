using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerTestController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public GameObject Canvas;
    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }
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
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);
    }
    public void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interactable")
        {
            Canvas.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Object Picked Up");
                Destroy(collision.gameObject);
            }
            
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interactable")
        {
            Canvas.gameObject.SetActive(false);
        }
    }
}
