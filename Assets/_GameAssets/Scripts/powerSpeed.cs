using System.Collections;
using UnityEngine;

public class PowerSpeedController : MonoBehaviour
{
    // Velocidad normal y velocidad aumentada
    public float boostedWalk = 6f;
    public float boostedRun = 12f;
    public float boostDuration = 5f; // Duración del aumento de velocidad en segundos
    private MeshRenderer meshRenderer;
    private FPSController playerController;
    private bool isBoosted = false;

    private void Start()
    {
        // Encuentra y almacena el componente FPSController
        playerController = FindObjectOfType<FPSController>();

        // Encuentra y almacena el componente MeshRenderer
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador entra en contacto con el objeto
        if (other.CompareTag("Player") && !isBoosted)
        {
            // Activa el aumento de velocidad y comienza la corrutina
            isBoosted = true;
            StartCoroutine(BoostSpeed());
        }
    }

    private IEnumerator BoostSpeed()
    {
        // Desactiva el MeshRenderer
        meshRenderer.enabled = false;

        // Aumenta la velocidad del jugador
        playerController.walkSpeed = boostedWalk;
        playerController.runSpeed = boostedRun;
        Debug.Log(" aumente la velocidad ");

        // Espera durante el tiempo especificado
        yield return new WaitForSeconds(boostDuration);
        Debug.Log(" esperando a eliminar ");

        // Restaura la velocidad normal
        playerController.walkSpeed = 3f;
        playerController.runSpeed = 6f;
        Debug.Log(" restaurando ");
        // Desactiva el aumento de velocidad
        isBoosted = false;
        Debug.Log(" desactivado ");

        // Destruye el objeto powerSpeed
        Destroy(gameObject);
    }
}
