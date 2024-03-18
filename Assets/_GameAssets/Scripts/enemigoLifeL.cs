using UnityEngine;

public class EnemigoLifeL : MonoBehaviour
{
    public int vidas = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            vidas--;
            Debug.Log("El enemigo ha sido golpeado. Vidas restantes: " + vidas);
            if (vidas <= 0)
            {
                Debug.Log("El enemigo ha sido derrotado.");
                // Si el enemigo queda sin vidas, se destruye
                Destroy(gameObject);
            }
        }
    }
}
