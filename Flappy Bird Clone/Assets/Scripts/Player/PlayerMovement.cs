using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [Header("Jump Options")]
    [SerializeField] private float JumpPower;
    [Space, SerializeField] private float fallMultiplier;
    [SerializeField] private float jumpMultiplier;

    [Space]
    [SerializeField] private KeyCode jumpKey;

    [Header("Events")]
    public UnityEvent OnJump;

    private Rigidbody2D rb2d;

    #region Unity Methods

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }

        if (rb2d.velocity.x < 0)
        {
            rb2d.gravityScale = fallMultiplier;
        }
        else
        {
            rb2d.gravityScale = jumpMultiplier;
        }
    }

    #endregion Unity Methods

    #region Movement

    private void Jump()
    {
        OnJump.Invoke();
        rb2d.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
    }

    #endregion Movement
}