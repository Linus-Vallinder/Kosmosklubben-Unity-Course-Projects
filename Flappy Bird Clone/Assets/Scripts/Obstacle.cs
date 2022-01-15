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
            print("Point");
        }
    }

    #endregion

    #region Scrolling

    private void Scroll()
    {
        transform.Translate(-transform.right * scrollSpeed * Time.deltaTime);
    }

    #endregion

    private void Despawner()
    {
        if (Vector3.Distance(transform.position, PlayerController.instance.transform.position) >= despawnDistance)
        {
            Destroy(gameObject);
        }
    }

    public void InitObstacle(Vector2 spawnYRange)
    {
        var obstacleHeight = Random.Range(spawnYRange.x, spawnYRange.y);
        transform.position = new Vector2(transform.position.x, obstacleHeight);
    }
}