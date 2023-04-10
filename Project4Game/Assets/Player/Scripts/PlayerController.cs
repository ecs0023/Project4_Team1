using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float flashlightDistance = 10f;
    public float flashlightAngle = 30f;
    public LayerMask solidLayer;
    public Light flashlight;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        UpdateFlashlight();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void UpdateFlashlight()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;

        if (direction.magnitude > 0.1f)
        {
            flashlight.transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, flashlightDistance, solidLayer);

            if (hit.collider != null)
            {
                Vector3 lightDirection = Quaternion.AngleAxis(flashlightAngle, Vector3.forward) * direction;
                Vector3 leftDirection = Quaternion.AngleAxis(-flashlightAngle, Vector3.forward) * direction;

                Debug.DrawLine(transform.position, transform.position + lightDirection * flashlightDistance, Color.yellow);
                Debug.DrawLine(transform.position, transform.position + leftDirection * flashlightDistance, Color.yellow);

                float angle = Vector3.Angle(lightDirection, hit.normal);
                float angleLeft = Vector3.Angle(leftDirection, hit.normal);

                if (angle < flashlightAngle || angleLeft < flashlightAngle)
                {
                    flashlight.intensity = 1f;
                }
                else
                {
                    flashlight.intensity = 0f;
                }
            }
            else
            {
                flashlight.intensity = 0f;
            }
        }
    }
}
