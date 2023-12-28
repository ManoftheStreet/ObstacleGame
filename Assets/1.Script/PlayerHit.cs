using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    int cnt = 0;
    Color originColor;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        MeshRenderer meshRenderer = collision.gameObject.GetComponent<MeshRenderer>();

        
        if (meshRenderer)
        {
            originColor = meshRenderer.material.color;
            meshRenderer.material.color = Color.green;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        cnt++;
        Debug.Log(cnt);
    }

    private void OnCollisionExit(Collision collision)
    {
        cnt = 0;
        Debug.Log(cnt);
        MeshRenderer meshRenderer = collision.gameObject.GetComponent<MeshRenderer>();

        if (meshRenderer)
        {
            meshRenderer.material.color = originColor;
        }
    }
}
