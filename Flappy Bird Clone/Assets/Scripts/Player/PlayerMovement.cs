using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Jump Options")]
    [SerializeField] private float JumpPower;

    [Space]
    [SerializeField] private KeyCode jumpKey;

    [Header("Player Rotation")]
    public float RotationMax;

    public SpriteRenderer playerSprite;
    private Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerSprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }

        PlayerRotate();
    }

    private void Jump()
    {
        rigidbody2d.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
        Debug.Log("Jump!");
    }

    private void PlayerRotate()
    {
        float rotation = 0.0f;

        rotation = RotationMax * rigidbody2d.velocity.normalized.x;

        playerSprite.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotation);
    }
}
