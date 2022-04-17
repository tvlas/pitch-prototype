using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementBehavior : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;
    public Vector2 minPower;
    public Vector2 maxPower;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Right click trigged");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Right click released");
        }
    }
}
