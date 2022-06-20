using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator knight;
    [SerializeField] private AudioSource playerAudio;
    public AudioClip playerJump;



    [Header("MovementVars")]
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float speed;
    [SerializeField] private bool isGrounded = false;
    [SerializeField] private bool facingRight = true;
    public static bool isControlled = true;


    [Header("Settings")]
    [SerializeField] private float jumpOffset;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private LayerMask groundMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        knight = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Vector3 overlapCirclePosition = groundColliderTransform.position;
        isGrounded = Physics2D.OverlapCircle(overlapCirclePosition, jumpOffset, groundMask);
    }
    public void Move(float direction, bool isJumpButtonPressed)
    {
        if (isJumpButtonPressed && isControlled)
        {
            Jump();
        }

        if (Mathf.Abs(direction) > 0.01 && isControlled)
        {
            HorizontalMovement(direction);
            knight.SetFloat("Velocity", Mathf.Abs(direction));
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            playerAudio.clip = playerJump;
            playerAudio.Play();
        }
    }

    private void HorizontalMovement(float direction)
    {
        if (isControlled)
        {
            rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        }
    }


    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}

   
