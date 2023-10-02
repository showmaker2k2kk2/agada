using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    
    public GameObject bulletPrefab;  // Prefab của đạn
    public Transform bulletSpawnPoint;  // Vị trí khởi tạo đạn
    public float bulletSpeed ;  // Tốc độ của đạn
    Bullet BU;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))  // Bắn khi người chơi nhấn nút bắn (có thể thay đổi theo thiết lập của bạn)
        {
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.transform.rotation);

        
         Rigidbody bulletController = bullet.GetComponent<Rigidbody>();
        bulletController.AddForce(bulletController.transform.forward * bulletSpeed);
        Destroy(bullet, 3);

        
    }


}


