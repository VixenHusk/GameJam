using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Armas : MonoBehaviour
{
    public int capacidad = 100;
    public int municion = 0; 
    public float fuerza = 10;
    public GameObject prefabBala;
    public Transform transformSpawner;
    public AudioClip audioShoot; // sonido balas
    public AudioClip audioNoBullets; // sonido sin balas
    public AudioClip audioReload; // sonido recarga
    private bool isReloadingSoundPlaying = false;

    public void Start(){
        municion = capacidad;
    }
    public void IntentarDisparo(){
        if (municion>0){
            Disparar();

        } else {
            GetComponent<AudioSource>().PlayOneShot(audioNoBullets);
        }
    }
    private void Disparar(){
        municion--;
        GameObject bala = Instantiate(prefabBala,transformSpawner.position, transformSpawner.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerza);
        GetComponent<AudioSource>().PlayOneShot(audioShoot);
    }

    private void StartReloadingSoundCooldown() {
    isReloadingSoundPlaying = false;
    }
    
    public void Reload(){
    if (!isReloadingSoundPlaying) {
        GetComponent<AudioSource>().PlayOneShot(audioReload);
        isReloadingSoundPlaying = true;
         Invoke("StartReloadingSoundCooldown", audioReload.length); // Reinicia el booleano después de que termine el sonido de recarga
    }
    municion = capacidad;
    }

}
