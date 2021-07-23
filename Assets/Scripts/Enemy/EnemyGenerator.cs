using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] asteroids;
    
    private void OnEnable()
    {
        StopAllCoroutines();
        StartCoroutine(StartSpawnLoop());
    }

    IEnumerator StartSpawnLoop()
    {
        while (true)
        {
            float time = Random.Range(0, 1f);
            yield return new WaitForSeconds(time);

            int sortedAsteroid = Random.Range(0, asteroids.Length);

            var asteroid = Instantiate(asteroids[sortedAsteroid]);

            float x = Random.Range(-3f, 3f);
            float y = transform.position.y;

            asteroid.transform.position = new Vector2(x, y);
            Destroy(asteroid, 3);
        }
    }
}
