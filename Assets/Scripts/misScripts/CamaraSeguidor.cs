using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidor : MonoBehaviour
{
    public Transform Objetivo;
    Vector3 CameraOffset;
    [Range(0.1f,1.0f)]
    public float FactorDeSuavizado = 0.5f;
    
    void Start()
    {
        CameraOffset = transform.position - Objetivo.position;
    }

    void Update()
    {
        Vector3 newPos = Objetivo.position + CameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, FactorDeSuavizado);
    }
}
