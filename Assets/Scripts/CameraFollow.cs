using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerT;
    private Vector3 CameraOffset;

    [Range(0.1f, 1.0f)]
    public float FactorSuavizado = 0.5f;

    void Start()
    {
        CameraOffset = transform.position - PlayerT.position;
    }

    void Update()
    {
        Vector3 newPos = PlayerT.position + CameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, FactorSuavizado);
    }
}
