using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarPuente : MonoBehaviour
{
    public GameObject puente;

    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneMadera = c.gameObject.GetComponent<Inventario>().HasItem("Madera(Clone)");
            if (tieneMadera){
                puente.SetActive(true);

            }
        }
    }
}
