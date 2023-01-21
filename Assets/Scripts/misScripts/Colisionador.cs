using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            
            ControladorJuego.instancia.RecibirDanio();
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Entro Objectivo");
        if (other.gameObject.name=="objetivo")
        {
            print("Entro Objectivo");
            ControladorJuego.instancia.Ganar();
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (other.gameObject.name == "PowerUp")
        {
            ControladorJuego.instancia.GanarVida();
            gameObject.GetComponent<ControladorAnimal>().PowerUp();
            Destroy(other.gameObject);
        }
    }

}
