using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isGravityFlipped = false; // Variable to keep track of gravity direction

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Check for changing the direction of gravity
        if (Input.GetKeyDown(KeyCode.A) && !isGravityFlipped)
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
            isGravityFlipped = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && isGravityFlipped)
        {
            Physics2D.gravity = new Vector2(0, 9.81f);
            isGravityFlipped = false;
        }
    }
}
