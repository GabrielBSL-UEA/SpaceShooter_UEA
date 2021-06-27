using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    [SerializeField] private GameObject spaceship;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSpaceship(0, false));
    }

    public void InstantiateSpaceship(int delay)
    {
        StartCoroutine(SpawnSpaceship(delay, true));
    }

    private IEnumerator SpawnSpaceship(int delay, bool removeLife)
    {
        yield return new WaitForSeconds(delay);

        if (lives <= 0) yield break;

        Instantiate(spaceship, transform.position, Quaternion.identity);
        if(removeLife) lives--;
    }
}
