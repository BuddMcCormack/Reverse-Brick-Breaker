using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Declare the variables and expose them to the unity editor
    public int Bounces = 3;
    public int MaximumBounces;

    // If the ball collides with anything that isn't the environment do nothing
    // otherwise if the ball is colliding with something tagged as environment ( Pegs and walls ) decrement bounces.
    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Environment")) return;

        Bounces--;
    }

    // Run ball to check the state of the ball
    private void Update()
    {
        Ball();
    }

    // If for some reason the current bounces is over the maximum amount of bounces allowed, set bounces to maximum bounce limit.
    // Also check if the balls current bounces are below 1 (aka 0) and if they are then remove the ball.
    public void Ball()
    {
        if (Bounces > MaximumBounces)
        {
            Bounces = MaximumBounces;
        }

        if (Bounces < 1)
        {
            Destroy(gameObject);
        }


    }
}
