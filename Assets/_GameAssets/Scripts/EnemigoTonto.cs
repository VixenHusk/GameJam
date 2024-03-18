using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : MonoBehaviour
{
    public float speed;
    public float minAngle;
    public float maxAngle;

    private GameObject suelo; // Ahora es una variable privada

    void Start()
    {
        // Buscar el GameObject llamado "Suelo" en la escena y asignarlo a la variable 'suelo'
        suelo = GameObject.Find("Terrain");

        // Comprobación para asegurarse de que se encontró el suelo
        if (suelo == null)
        {
            Debug.LogError("No se encontró el GameObject 'Terrain'");
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision c)
    {
        // Si se encontró el suelo, realiza la rotación
        if (suelo != null)
        {
            transform.Rotate(0, Random.Range(minAngle, maxAngle), 0);
        }
    }
}
