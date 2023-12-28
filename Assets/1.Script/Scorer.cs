using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    static int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
            gameObject.tag = "Hit";
            hits++;
            Debug.Log($"You Bumped {gameObject.name} many time : {hits}");
        }
    }
}
