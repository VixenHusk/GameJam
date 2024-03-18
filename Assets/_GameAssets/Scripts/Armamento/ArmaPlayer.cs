using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArmaPlayer : MonoBehaviour
{
    public Armas arma;
    public float fireRate = 0.1f;
    public float nextFire= 0f;
    public AudioClip audioReload; // variable publica del fichero de audio

    void Update(){
        // Verificar si el boton izquierdo del raton esta siendo presionado y si es tiempo de disparar
        if (Input.GetMouseButton(0) && Time.time >= nextFire)
        {
            // Actualizar el tiempo del proximo disparo
            nextFire = Time.time + fireRate;

            // Llamar al metodo Shoot()
            ApretarGatillo();
        }  
    }


    public void ApretarGatillo(){
        arma.IntentarDisparo();
    }
}

