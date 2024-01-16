using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;

public class gato : MonoBehaviour
{

   public Button btn;
   public TMP_Text txtJuego;
   public AudioSource clip;

   private int[,] matrizGato = new int[3,3]; 
   private int turno = 0; 
   private int ganador = 0, movimientos = 0;



    void Start() {
        IniciaGato();
        txtJuego.text = "Juego Nuevo";
    }
    public void PlaySound()
    {
        clip.Play();
    }


    public void AsignaTurno(Button btn) { 
        if (ganador == 0 && ObtenValorMatrizGato(btn.name) == 0) {     
            if (turno == 0) {
                turno = 1;      
            } else if (turno == 1) {
                turno = 2;     
            } else {
                turno = 1; 
            }
            txtJuego.text = "Juego en Curso";
            DibujaSimbolo(btn, turno);
            EscribeValorMatrizGato(btn.name, turno);
            movimientos++;
            VerificaGanador(); 
        }
    }

    private void DibujaSimbolo(Button btn,  int t) { 
        if (t == 1) {
            btn.GetComponentInChildren<TMP_Text>().text = "x";
        } else {
            btn.GetComponentInChildren<TMP_Text>().text = "o";  
        }
    }


    private int ObtenValorMatrizGato(string btn) { 
        int a = -1; 
        switch(btn) {
           case "Btn1":
                a = matrizGato[0, 0]; 
                break;
            case "Btn2":
                a = matrizGato[0, 1];
                break;
            case "Btn3":
                a = matrizGato[0, 2];
                break;
            case "Btn4":
                a = matrizGato[1, 0];
                break;
            case "Btn5":
                a = matrizGato[1, 1];
                break;
            case "Btn6":
                a = matrizGato[1, 2]; 
                break;
            case "Btn7":
                a = matrizGato[2, 0];
                break;
            case "Btn8":
                a = matrizGato[2, 1];
                break;
            case "Btn9":
                a = matrizGato[2, 2];
                break; 
        }
        return a;
    }


    private void EscribeValorMatrizGato(string btn, int t) {  
        switch (btn) {
            case "Btn1":
                matrizGato[0, 0] = t; 
                break;
            case "Btn2":
                matrizGato[0, 1] = t; 
                break;
            case "Btn3":
                matrizGato[0, 2] = t; 
                break;
            case "Btn4":
                matrizGato[1, 0] = t; 
                break;
            case "Btn5":
                matrizGato[1, 1] = t; 
                break;
            case "Btn6":
                matrizGato[1, 2] = t; 
                break;
            case "Btn7":
                matrizGato[2, 0] = t; 
                break;
            case "Btn8":
                matrizGato[2, 1] = t; 
                break;
            case "Btn9":
                matrizGato[2, 2] = t; 
                break;

        }
    }

    private void VerificaGanador() {
        //Ganador x para cada uno de los 3 renglones
        if (matrizGato[0, 0] == 1 && matrizGato[0, 1] == 1 && matrizGato[0, 2] == 1) { 
            ganador = 1; 
        }
        if (matrizGato[1, 0] == 1 && matrizGato[1, 1] == 1 && matrizGato[1, 2] == 1) { 
            ganador = 1; 
        }
        if (matrizGato[2, 0] == 1 && matrizGato[2, 1] == 1 && matrizGato[2, 2] == 1) { 
            ganador = 1; 
        }
        //Ganador o para cada uno de los 3 renglones
        if (matrizGato[0, 0] == 2 && matrizGato[0, 1] == 2 && matrizGato[0, 2] == 2) { 
            ganador = 2; 
        }
        if (matrizGato[1, 0] == 2 && matrizGato[1, 1] == 2 && matrizGato[1, 2] == 2) { 
            ganador = 2; 
        }
        if (matrizGato[2, 0] == 2 && matrizGato[2, 1] == 2 && matrizGato[2, 2] == 2) { 
            ganador = 2; 
        }
        //Ganador x para cada una de las 3 columnas
        if (matrizGato[0, 0] == 1 && matrizGato[1, 0] == 1 && matrizGato[2, 0] == 1) { 
            ganador = 1; 
        }
        if (matrizGato[0, 1] == 1 && matrizGato[1, 1] == 1 && matrizGato[2, 1] == 1) { 
            ganador = 1; 
        }
        if (matrizGato[0, 2] == 1 && matrizGato[1, 2] == 1 && matrizGato[2, 2] == 1) { 
            ganador = 1; 
        }
        //Ganador o para cada uno de las 3 columnas
        if (matrizGato[0, 0] == 2 && matrizGato[1, 0] == 2 && matrizGato[2, 0] == 2) { 
            ganador = 2; 
        }
        if (matrizGato[0, 1] == 2 && matrizGato[1, 1] == 2 && matrizGato[2, 1] == 2) { 
            ganador = 2; 
        }
        if (matrizGato[0, 2] == 2 && matrizGato[1, 2] == 2 && matrizGato[2, 2] == 2) { 
            ganador = 2; 
        }
        //Ganador x para cada una de las 2 diagonales
        if (matrizGato[0, 0] == 1 && matrizGato[1, 1] == 1 && matrizGato[2, 2] == 1) { 
            ganador = 1; 
        }
        if (matrizGato[0, 2] == 1 && matrizGato[1, 1] == 1 && matrizGato[2, 0] == 1) { 
            ganador = 1; 
        }
        //Ganador o para cada una de las 2 diagonales
        if (matrizGato[0, 0] == 2 && matrizGato[1, 1] == 2 && matrizGato[2, 2] == 2) { 
            ganador = 2; 
        }
        if (matrizGato[0, 2] == 2 && matrizGato[1, 1] == 2 && matrizGato[2, 0] == 2) { 
            ganador = 2; 
        }
        if (ganador == 0 && movimientos == 9) {
            txtJuego.text = "Empate";
        } 
        if (ganador == 1) {
            txtJuego.text = "Ganador: X";
        }
        if (ganador == 2) {
            txtJuego.text = "Ganador: O";
        }
    }

    private void IniciaGato() {            
        for (int i = 0; i<3; i++) {        
            for (int j = 0; j<3; j++) {    
                matrizGato[i, j] = 0;     
            }
        }

        GameObject.Find("Btn1").GetComponentInChildren<TMP_Text>().text = ""; 
        GameObject.Find("Btn2").GetComponentInChildren<TMP_Text>().text = ""; 
        GameObject.Find("Btn3").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn4").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn5").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn6").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn7").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn8").GetComponentInChildren<TMP_Text>().text = "";
        GameObject.Find("Btn9").GetComponentInChildren<TMP_Text>().text = "";

    }

    public void ReiniciaJuego() {
        SceneManager.LoadScene("Main");
    }

}