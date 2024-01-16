using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void InicialAMain () {
        SceneManager.LoadScene("Main");
    }

     public void MainAInicial () {
        SceneManager.LoadScene("Inicial");
    }
    public void MenuInicio () {
        SceneManager.LoadScene("Inicio");
    }

}
