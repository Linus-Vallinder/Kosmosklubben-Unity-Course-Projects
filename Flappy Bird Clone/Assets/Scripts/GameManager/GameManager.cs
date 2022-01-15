using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    #region Unity Methods

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    #endregion Unity Methods
}