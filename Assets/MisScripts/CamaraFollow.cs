using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform PlayerT;
    private Vector3 CameraOffset;
    [Range(0.01f,1)]
    public float FactorSuavizado = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        CameraOffset = transform.position - PlayerT.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = PlayerT.position + CameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, FactorSuavizado);
    }
}
