using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Jump Options")]
    [SerializeField] private float JumpPower;

    [Space]
    [SerializeField] private KeyCode jumpKey;

    private Rigidbody2D rb2d;

    #region Unity Methods

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(jumpKey))
        {
            Jump();
        }
    }

    #endregion Unity Methods

    #region Movement

    private void Jump()
    {
        rb2d.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
    }

    #endregion Movement
}