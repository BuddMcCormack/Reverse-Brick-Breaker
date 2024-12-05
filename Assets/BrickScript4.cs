using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript4 : MonoBehaviour
{
    // Make it so if the brick is hit by anything other than the ball it isn't broken
    // otherwise if hit by an object containing the ball tag destroy it.

    // Also add score of brick layer 4
    public void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;
        ScoreManager.instance.AddScore4();
        Destroy(gameObject);
    }
}