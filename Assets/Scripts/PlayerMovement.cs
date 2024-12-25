using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    private static readonly float MovementSpeed = 3.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        Run();
        Jump();
    }

    void Walk()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MovementSpeed, rb.velocity.y);
    }

    void Run()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MovementSpeed * 2, rb.velocity.y);
    }

    void Jump()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Vertical") * MovementSpeed, rb.velocity.y);
    }
}