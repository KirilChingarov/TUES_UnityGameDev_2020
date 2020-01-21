using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public uint AsteroidsCount = 5;
    public GameObject AsteroidClone;
    // Start is called before the first frame update
    void Start()
    {
        float depth = Camera.main.transform.position.y - transform.position.y;
        for (uint i = 0; i < AsteroidsCount; i++) {
            Vector3 ViewportPos = new Vector3(Random.value, Random.value, depth);
            Vector3 WorldPos = Camera.main.ViewportToWorldPoint(ViewportPos);
            Instantiate(AsteroidClone, WorldPos, Random.rotation);
        }
    }

}
