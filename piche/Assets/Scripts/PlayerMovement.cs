using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float power = 50f;
    public Rigidbody2D rb;
    public Vector2 minPower;
    public Vector2 maxPower;

    TrajectoryLine tl;
    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToViewportPoint(Input.mousePosition);
            startPoint.z = 15;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.ScreenToViewportPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToViewportPoint(Input.mousePosition);
            endPoint.z = 15;
            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), 
            Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
            tl.EndLine();
        }
    }
}