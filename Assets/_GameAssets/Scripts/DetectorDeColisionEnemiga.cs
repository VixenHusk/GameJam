using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DetectorDeColisionEnemiga : MonoBehaviour
{
    public TMP_Text textObject;
    public int puntuacion = 0;

    public int PuntosPorDisparo = 1;
    private void Start()
    {
        textObject = GameObject.Find("TextPuntuacion").GetComponent<TMP_Text>();
    }
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Enemigo"))
        {
            puntuacion = Int32.Parse(textObject.text) + PuntosPorDisparo;
            textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacion.ToString());
            Destroy(this.gameObject);
        } /*else
        {
            Destroy(this.gameObject);
        }*/

    }




}
