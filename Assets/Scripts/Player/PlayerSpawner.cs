using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spaceship;

    public static PlayerSpawner Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(SpawnSpaceship(0));
    }

    public void InstantiateSpaceship(int delay)
    {
        StopAllCoroutines();
        StartCoroutine(SpawnSpaceship(delay));
    }

    private IEnumerator SpawnSpaceship(int delay)
    {
        yield return new WaitForSeconds(delay);

        if (!GameController.Instance.RemoveLife()) yield break;

        Instantiate(spaceship, transform.position, Quaternion.identity);
    }
}
