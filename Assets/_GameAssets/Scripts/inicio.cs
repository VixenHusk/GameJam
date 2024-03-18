using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{

    public void IniciarJuego(){
      SceneManager.LoadScene(0);
    }
    public void PlayJuego(){
      SceneManager.LoadScene(2);
    }
    public void SalirJuego(){
      Application.Quit();
    }
}

