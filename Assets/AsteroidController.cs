using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float MaxSpeed = 3.5f;
    public float MinSpeed = 1f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        transform.LookAt(player.transform);

        rb.velocity = transform.forward * Random.Range(MaxSpeed, MinSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
