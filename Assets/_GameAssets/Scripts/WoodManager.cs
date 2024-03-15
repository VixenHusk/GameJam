using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WoodManager : MonoBehaviour
{
    // para añadir canvas public GameObject imagenLlave;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Madera")){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            // Añadir canvas imagenMadera.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject); // añadir llave inventario
        }
    }
}
