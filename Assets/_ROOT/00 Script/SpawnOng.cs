using System;
using UnityEngine;

public class SpawnOng : MonoBehaviour
{
    [SerializeField] private float spawnTime = 2;
    private float countDown;
    [SerializeField] private GameObject ongPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform parentOng;

    [Header("Config Y")] [SerializeField] private float minY;
    [SerializeField] private float maxY;

    void Start()
    {
        countDown = spawnTime;
    }

    private void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            Spawn();
            countDown = spawnTime;
        }
    }

    private void Spawn()
    {
        Transform newSpawnPoint = spawnPoint;
        newSpawnPoint.position = new Vector3(spawnPoint.position.x, UnityEngine.Random.Range(minY, maxY),
            spawnPoint.position.z);
        Instantiate(ongPrefab, newSpawnPoint.position, Quaternion.identity, parentOng);
    }
}