using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour
{
    [Header("Textos")]
    public GameObject ganar;
    public GameObject perder;
    [Header("Controlador")]
    public ControladorAnimal CA;
    [Header("Vida")]
    public Slider barraVida;
    public Text txtVida;
    public int vida=10;
    public bool Play = true;
    public static ControladorJuego instancia;
    public AudioSource musica;
    private void Awake()
    {
        mostarVida();
        instancia = this;
        musica = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !Play)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void RecibirDanio()
    {
        if (vida == 0) return;
        vida = vida - 1;
        mostarVida();
        if (vida == 0)
        {
            perder.SetActive(true);
            Play = false;
            CA.enabled = false;
            musica.Stop();
        }
    }
    public void GanarVida()
    {
        if (vida == 10) return;
        if (vida == 9)
        {
            vida++;
            mostarVida();
        }
        else
        {
            vida = vida + 2;
            mostarVida();
        }
    }

    public void Ganar()
    {
        ganar.SetActive(true);
        Play = false;
        CA.enabled = false;
        musica.Stop();
    }

    public void mostarVida()
    {
        barraVida.value = vida;
        txtVida.text = "Hp:" + vida.ToString();
      
    }
    public void Cerrar()
    {
        Application.Quit();
    }
}



