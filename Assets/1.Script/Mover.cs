using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    float xValue;
    float zValue;

    void Start()
    {
        
    }

    void Update()
    {
        KeyInput();
        MovePlayer();
    }

    void KeyInput()
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
    }

    void MovePlayer()
    {
        transform.Translate(xValue, 0, zValue);
    }

    void PrintString()
    {

    }
}
