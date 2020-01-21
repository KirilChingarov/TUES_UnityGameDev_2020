using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float shoot = Input.GetAxis("Fire1");
        if(shoot != 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
