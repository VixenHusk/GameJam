using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoTonto : MonoBehaviour
{
    public float speed;
    public float minAngle;
    public float maxAngle;

    public GameObject suelo;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name != suelo.name)
        {
            transform.Rotate(0, Random.Range(minAngle, maxAngle), 0);
        }
    }
}
