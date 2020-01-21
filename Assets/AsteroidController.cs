using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float MaxSpeed = 3.5f;
    public float MinSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector2 velocity = Random.insideUnitCircle * Random.Range(MaxSpeed, MinSpeed);
        rb.velocity = new Vector3(velocity.x, 0, velocity.y);
    }

}
