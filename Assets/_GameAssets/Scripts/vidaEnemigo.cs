using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaEnemigo : MonoBehaviour
{
    public int vidas = 2; // Número inicial de vidas

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si la colisión es con un objeto que tenga la etiqueta "Obstaculo"
        if (other.gameObject.CompareTag("Bala"))
        {
            // Resta una vida
            vidas--;

            // Verifica si las vidas llegan a cero
            if (vidas <= 0)
            {
                // Si las vidas llegan a cero, destruye el objeto y muestra un efecto de explosión
                Destroy(gameObject);
                Debug.Log("Game Over - El objeto ha perdido todas sus vidas");
            }
            else
            {
                Debug.Log("El objeto ha perdido una vida. Vidas restantes: " + vidas);
            }
        }
    }   
}
