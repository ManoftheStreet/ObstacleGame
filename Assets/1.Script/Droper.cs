using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rb;
    [SerializeField] float dropTime = 2.0f;
    [SerializeField] float visibleTime = 0.5f;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Time.time > visibleTime && meshRenderer)
        {
            meshRenderer.enabled = true;

            if(Time.time > dropTime && rb)
            {
                rb.useGravity = true;
            }
        }
    }
}
