using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;

    void Update()
    {
       
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        // Xử lý va chạm với các đối tượng khác
        // Ví dụ: hủy đối tượng đạn khi va chạm
        Destroy(gameObject);
    }
}

