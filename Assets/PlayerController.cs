using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalSpeed = 1.0f;
    public float horizontalSpeed = 1.0f;
    public float turnAngle = 40f;

    void Start()
    {
        
    }

    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal") * Time.deltaTime * horizontalSpeed;
        float depth = Camera.main.transform.position.y - transform.position.y;

        Vector3 mouseScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, depth);
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenSpace);
        Vector3 displacement = new Vector3(horizontalAxis, 0, verticalAxis) * Time.deltaTime * verticalSpeed;

        transform.LookAt(mouseWorldSpace);
        displacement = transform.rotation * displacement;
        transform.Rotate(0f, 0f, (0 - turnAngle) * horizontalAxis, Space.Self);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.MovePosition(transform.position + displacement);

    }
}
