using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Score")]
    public int score;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;


    #region Unity Methods

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        scoreText.text = score + "";
    }

    #endregion Unity Methods
}