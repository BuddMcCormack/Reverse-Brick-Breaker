using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    // Determines if ball has collided with the ground, if it has the ball is removed and 1000 points is gained.

    public void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Ground")) return;
        ScoreManager.instance.AddScore();
        Destroy(gameObject);
    }
}
