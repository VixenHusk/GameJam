using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;

    void Start() 
    {
        Invoke("DestroyBullet", lifeTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Verificar si la colisión es con un objeto que tiene la etiqueta "Enemy"
        if (other.CompareTag("Enemy"))
        {
            DestroyBullet();
        }
    }

    // Método para destruir la bala
    void DestroyBullet()
    {
        Destroy(gameObject);
    }

}
