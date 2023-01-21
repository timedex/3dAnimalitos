using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Enemigo"){
            GameManagerJuego2.instance.RecibirDano();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "objetivo")
        {
            GameManagerJuego2.instance.Ganar();
        }
        if (other.gameObject.name == "PowerUp")
        {
            GameManagerJuego2.instance.GanarVida();
            gameObject.GetComponent<PlayerControllerVoxel>().powerUPP();
            Destroy(other.gameObject);
        }
    }
   
}
