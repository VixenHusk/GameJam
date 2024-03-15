using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munición : MonoBehaviour
{
    public Armas arma; // Referencia al script de las armas


    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("municion")){
            //1. Desaparece la llave
            //Destroy(c.gameObject);
            arma.Reload(); // Recargar munición del arma asociada
        }
    }

}