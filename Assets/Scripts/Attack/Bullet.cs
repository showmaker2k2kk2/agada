using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    protected int dameshoogun = 5;

    void Update()
    {
       
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        ITakadame dame =GetComponent<ITakadame>();
        dame?.TakeDame(dameshoogun);
      
        Destroy(gameObject);
    }
}

