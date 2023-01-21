using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetidor : MonoBehaviour
{

    Vector3 posInicial;
    public Transform posRespawn;
    public int posMax;
    void Start()
    {
        posInicial = posRespawn.position;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position,posInicial)>posMax)
        {
            transform.position = posInicial;
        }
    }
}
