using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private Vector3 spawnValues;
    private float spawnWait;
    [SerializeField] private float spawnMostWait;
    [SerializeField] private float spawnLeastWait;
    [SerializeField] private int startWait;
    [SerializeField] private bool stop;

    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnMostWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield
        return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, enemies.Length);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1f, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield
            return new WaitForSeconds(spawnWait);
        }
    }
}