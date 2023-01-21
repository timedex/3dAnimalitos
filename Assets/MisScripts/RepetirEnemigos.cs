using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirEnemigos : MonoBehaviour
{
    private Vector3 posInicial;
    public Transform posRespawn;
    public int maxPosicion;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = posRespawn.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, posInicial)> maxPosicion)
        {
            transform.position = posInicial;
        }
    }
}
