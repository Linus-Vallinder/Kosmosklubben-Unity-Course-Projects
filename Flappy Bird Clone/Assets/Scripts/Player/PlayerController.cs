using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private PlayerMovement playerMovement;

    #region Unity Methods

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    #endregion Unity Methods
}