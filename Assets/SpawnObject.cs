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
    public int CannonBallCount = 5;
    public int TennisBallCount = 10;
    public int DodgeBallCount = 15;
    public int MetalBallCount = 8;
    public int GlassBallCount = 8;
    public float Movespeed = 8f;
    bool canMove = true;

    void Update()
    {
        if (canMove == true)
        {

            Vector3 moveOffset = Vector3.zero;
            moveOffset.x = Input.GetAxis("Horizontal");
            moveOffset.x = moveOffset.x * Movespeed * Time.deltaTime;
            transform.position += moveOffset;
        }

    }
}
