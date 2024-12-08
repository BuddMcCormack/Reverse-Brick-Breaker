using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnObject : MonoBehaviour
{
    public GameObject CannonBall;
    public GameObject TennisBall;
    public GameObject DodgeBall;
    public GameObject MetalBall;
    public GameObject GlassBall;
    public GameObject ChickenBall;
    public GameObject HorseBall;

    public int CannonBallCount = 5;
    public int TennisBallCount = 10;
    public int DodgeBallCount = 15;
    public int MetalBallCount = 8;
    public int GlassBallCount = 8;
    public float Movespeed = 8f;
    bool canMove = true;
    public float LimitLeft = -7.20f;
    public float LimitRight = 7.20f;
    bool lastResort = false;

    

    public void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Environment")) return;
        canMove = false;

    }

    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.H) && lastResort == true)
        {
            Vector3 horseOffset = new Vector3(0, -1, 0);
            Instantiate(HorseBall, transform.position + horseOffset, Quaternion.identity);

        }

        if (CannonBallCount < 1 && TennisBallCount < 1 && DodgeBallCount < 1 && MetalBallCount < 1 && GlassBallCount < 1)
        {
            lastResort = true;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {

            Instantiate(ChickenBall, transform.position, Quaternion.identity);
        }
    }
}
