using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private PlayerMovement playerMovement;

    [HideInInspector] public bool isDead = false;

    [Header("Events")]
    public UnityEvent OnDeath;

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

    #region Death

    public void Die()
    {
        OnDeath.Invoke();
        isDead = true;
    }

    #endregion
}