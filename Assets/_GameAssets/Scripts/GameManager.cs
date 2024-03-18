using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int puntosObjetivo = 5; // Define aquí la cantidad de puntos necesarios para no perder el juego
    public float tiempoLimite = 10f; // Define aquí el tiempo límite en segundos
    public TextMeshProUGUI textoPuntuacion; // Asigna el TextMeshPro donde muestras la puntuación

    private float tiempoTranscurrido = 0f;
    private bool gameOver = false;

    void Update()
    {
        // Si el juego no ha terminado, actualizar el tiempo y verificar si se ha alcanzado el límite de tiempo
        if (!gameOver)
        {
            tiempoTranscurrido += Time.deltaTime;

            if (tiempoTranscurrido >= tiempoLimite)
            {
                TerminarJuego("Tiempo agotado");
            }
        }

        // Obtener la puntuación actual
        int puntuacionActual = ObtenerPuntuacion();

        // Verificar si se alcanzó la cantidad de puntos requerida
        if (puntuacionActual >= puntosObjetivo)
        {
            // Si se alcanzaron los puntos requeridos, el juego termina con victoria
            GanarJuego("Has ganado");
        }
    }

    int ObtenerPuntuacion()
    {
        // Aquí debes obtener la puntuación actual del jugador desde donde la almacenas en tu juego.
        // Puedes modificar este método según cómo estés gestionando la puntuación en tu juego.
        int puntuacion = int.Parse(textoPuntuacion.text);
        return puntuacion;
    }

    void GanarJuego(string mensaje){
        gameOver = true;
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // Aquí puedes desencadenar cualquier acción que desees cuando el juego termine.
        Debug.Log("Game Over - " + mensaje);
    }

    void TerminarJuego(string mensaje)
    {
        gameOver = true;
        SceneManager.LoadScene(4);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // Aquí puedes desencadenar cualquier acción que desees cuando el juego termine.
        Debug.Log("Game Over - " + mensaje);
    }

}
