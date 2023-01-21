using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPerseguidora : MonoBehaviour
{
    public Transform player;
    Vector3 cameraOffset;

    [Range(0.1f, 1.0f)]
    public float factorSuavizado = 0.5f;
    
    void Start()
    {
        cameraOffset = transform.position - player.position;
    }
    void Update()
    {
        Vector3 nuevoPosicion = player.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, nuevoPosicion, factorSuavizado);
    }
}
