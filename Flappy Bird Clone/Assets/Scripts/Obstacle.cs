using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [Header("Obstacle Options")]
    [SerializeField] private float scrollSpeed;

    [SerializeField] private float despawnDistance;

    #region Unity Methods

    private void Update()
    {
        Scroll();
        Despawner();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.score++;
        }
    }

    #endregion Unity Methods

    #region Scrolling

    private void Scroll()
    {
        transform.Translate(-transform.right * scrollSpeed * Time.deltaTime);
    }

    #endregion Scrolling

    #region Spawning

    private void Despawner()
    {
        if (Vector3.Distance(transform.position, Vector3.zero) >= despawnDistance)
        {
            Destroy(gameObject);
        }
    }

    #endregion Spawning

    public void InitObstacle(Vector2 spawnYRange)
    {
        var obstacleHeight = Random.Range(spawnYRange.x, spawnYRange.y);
        transform.position = new Vector2(transform.position.x, obstacleHeight);
    }
}