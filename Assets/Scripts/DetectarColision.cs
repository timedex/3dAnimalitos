using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemigo"){
            GameManagerJuego.instance.RecibirDano();   
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "objetivo")
        {
            GameManagerJuego.instance.Ganar();
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (other.gameObject.name == "PowerUp")
        {
            GameManagerJuego.instance.GanarVida();
            gameObject.GetComponent<PlayerControllerVoxel>().powerUPP();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "muro")
        {
            other.isTrigger = false;         
        }
    }


}
