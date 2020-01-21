using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject player;
    public float safeZone = 20f;
    public uint StartingAsteroidsCount = 5;
    public GameObject AsteroidClone;
    public float initialSpawnTime;
    public float spawnDelay;
    private float angle;

    void Start()
    {
        for (int i = 0;i < StartingAsteroidsCount;i++)
        {
            SpawnAsteroid();
        }
        InvokeRepeating("SpawnAsteroid", initialSpawnTime, spawnDelay);
    }

    void SpawnAsteroid()
    {
        angle = Random.Range(-Mathf.PI, Mathf.PI);
        Vector3 spawn = player.transform.position;
        spawn += new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * safeZone;

        Instantiate(AsteroidClone, spawn, Random.rotation);
    }
}
