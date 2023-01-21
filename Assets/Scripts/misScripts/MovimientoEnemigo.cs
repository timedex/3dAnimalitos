using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Vector3 movimiento;
    void Update()
    {
        transform.position = transform.position + movimiento*Time.deltaTime;
    }
}
