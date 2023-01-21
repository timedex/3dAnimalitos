using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerJuego : MonoBehaviour
{
    public GameObject ganar;
    public GameObject perder;
    public PlayerControllerVoxel PC;
    public Slider barra;
    public Text txtVida;
    public int vida = 10;
    private bool Play=true;
    public static GameManagerJuego instance;
    private void Awake()
    {
        MostrarVida();
        instance = this;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Play)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void RecibirDano(){
        if (vida == 0) return;
        vida = vida-1;
        MostrarVida();
        if (vida == 0)
        {
            perder.SetActive(true);
            Play = false;
            PC.enabled = false;
        }
    }
    public void GanarVida()
    {
        if (vida == 10) return;
        if (vida == 9) {
            vida = vida + 1;
            MostrarVida();
        }
        else
        {
            vida = vida + 2;
            MostrarVida();
        }
    }
    private void MostrarVida()
    {
        barra.value = vida;
        txtVida.text = "HP:" + vida;
    }
    public void Ganar(){
            Play = false;
            ganar.SetActive(true);
            PC.enabled = false;
    }
}
