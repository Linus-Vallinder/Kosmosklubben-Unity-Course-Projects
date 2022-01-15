using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Obstacle")]
    [SerializeField] private GameObject obstaclePrefab;

    [Header("Spawning Options")]
    [SerializeField] private Vector2 spawningTimeRange;
    [SerializeField] private Vector2 spawningHeightRange;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(spawningTimeRange.x, spawningTimeRange.y));
            Spawn();
        }
    }

    private void Spawn()
    {
        var clone = Instantiate(obstaclePrefab, new Vector3(10, 0, 0), Quaternion.identity);
        Obstacle obstacle = clone.GetComponent<Obstacle>();

        if(obstacle != null)
        {
            obstacle.InitObstacle(spawningHeightRange);
        }
    }
}