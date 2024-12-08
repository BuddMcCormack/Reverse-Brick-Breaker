using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnObject : MonoBehaviour
{
    // Define anything that's a ball, making lots of public variables for prototyping.
    public GameObject CannonBall;
    public GameObject TennisBall;
    public GameObject DodgeBall;
    public GameObject MetalBall;
    public GameObject GlassBall;
    public GameObject ChickenBall;
    public GameObject HorseBall;

    // Define a public ball limit so variables can be edited easily.
    public int CannonBallCount = 5;
    public int TennisBallCount = 10;
    public int DodgeBallCount = 15;
    public int MetalBallCount = 8;
    public int GlassBallCount = 8;

    // Movement Variables
    public float Movespeed = 8f;
    bool canMove = true;
    public float LimitLeft = -7.20f;
    public float LimitRight = 7.20f;

    // A funny horse ball variable, lastResort is a bool which determines if you've run out of balls.
    bool lastResort = false;

    
    // Make it so the object can't go through the defined enviroment.
    public void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Environment")) return;
        canMove = false;

    }

    void Update()
    {

        // Defines when the player can move, Horizontal ( A,D leftarrow,righarrow ) axis moves the object to a new X position.
        if (canMove == true)
        {

            Vector3 moveOffset = Vector3.zero;
            moveOffset.x = Input.GetAxis("Horizontal");
            moveOffset.x = moveOffset.x * Movespeed * Time.deltaTime;
            Vector3 newPos = transform.position + moveOffset;

            if (newPos.x < LimitLeft)
            {

                newPos.x = LimitLeft;
            }
            if (newPos.x > LimitRight)
            {

                newPos.x = LimitRight;
            }

            transform.position = newPos;
        }

        // All the balls instatiated with keybinds and counting how many balls have been dropped from a defined limit.
        if (Input.GetKeyDown(KeyCode.Q) && CannonBallCount > 0)
        {

            Instantiate(CannonBall, transform.position, Quaternion.identity);
            CannonBallCount--;
        }

        if (Input.GetKeyDown(KeyCode.W) && TennisBallCount > 0)
        {

            Instantiate(TennisBall, transform.position, Quaternion.identity);
            TennisBallCount--;
        }

        if (Input.GetKeyDown(KeyCode.E) && DodgeBallCount > 0)
        {

            Instantiate(DodgeBall, transform.position, Quaternion.identity);
            DodgeBallCount--;
        }

        if (Input.GetKeyDown(KeyCode.R) && MetalBallCount > 0)
        {

            Instantiate(MetalBall, transform.position, Quaternion.identity);
            MetalBallCount--;
        }

        if (Input.GetKeyDown(KeyCode.T) && GlassBallCount > 0)
        {

            Instantiate(GlassBall, transform.position, Quaternion.identity);
            GlassBallCount--;
        }

        // " Last Resort ", a secret button which spawns bouncy horses which act like balls.

        if (Input.GetKeyDown(KeyCode.H) && lastResort == true)
        {
            Vector3 horseOffset = new Vector3(0, -1, 0);
            Instantiate(HorseBall, transform.position + horseOffset, Quaternion.identity);

        }

        // Determines if lastResort is active.

        if (CannonBallCount < 1 && TennisBallCount < 1 && DodgeBallCount < 1 && MetalBallCount < 1 && GlassBallCount < 1)
        {
            lastResort = true;
        }

        // Super secret chicken button, spawns infinite bouncy chickens which act like balls.
        if (Input.GetKeyDown(KeyCode.C))
        {

            Instantiate(ChickenBall, transform.position, Quaternion.identity);
        }
    }
}
