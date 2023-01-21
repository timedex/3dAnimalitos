using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigo : MonoBehaviour
{
    public Vector3 velocidad;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + velocidad;
    }
}
