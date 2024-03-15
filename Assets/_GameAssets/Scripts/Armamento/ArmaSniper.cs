using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ArmaSniper : MonoBehaviour
{
    public int capacidad = 10;
    public int municion = 0; 
    public float fuerza = 10;
    public Transform transformOrigenRayCast;

    public AudioClip audioShoot;
    public AudioClip audioNoBullets;

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
        GetComponent<AudioSource>().PlayOneShot(audioShoot);
        municion--;
        //Disparar con RayCast
        RaycastHit hitInfo;
        bool hayImpacto = Physics.Raycast(transformOrigenRayCast.position, transformOrigenRayCast.forward, out hitInfo);
        if (hayImpacto){
            if (hitInfo.transform.CompareTag("Enemy")){
                hitInfo.transform.GetComponentInChildren<Rigidbody>().AddForce(Vector3.up * 300);
            }
        }
    }

    public void Reload(){
        municion = capacidad;
    }
}
