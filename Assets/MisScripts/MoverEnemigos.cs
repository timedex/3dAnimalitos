using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 velocidadVector;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + velocidadVector * Time.deltaTime;
    }
}
