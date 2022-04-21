using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float power = 1f;
    public Camera cam;
    Vector3 getMouseEvents;
    LineRenderer lr;
    Vector3 endPoint;
    Vector3 startPoint;
    float maxDistance = 5;

    private void Start()
    {
        Application.targetFrameRate = 60;
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
    }

    void Update()
    {
        getMouseEvents = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseDirection = getMouseEvents - gameObject.transform.position;
        mouseDirection.z = 0;
        mouseDirection = mouseDirection.normalized;

        if (Input.GetMouseButtonDown(0))
        {
            lr.enabled = true;
            rb.velocity = Vector2.zero;
        }

        if (Input.GetMouseButton(0))
        {
            Time.timeScale = 0.3f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            startPoint = gameObject.transform.position;
            startPoint.z = 0;
            lr.SetPosition(0, startPoint);
            endPoint = getMouseEvents;
            endPoint.z = 0;
            float dist = Mathf.Clamp(Vector2.Distance(startPoint, endPoint), 0, maxDistance);
            endPoint = startPoint + (mouseDirection * dist);
            lr.SetPosition(1, endPoint);
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;

            Vector3 zero = lr.GetPosition(0);
            Vector3 one = lr.GetPosition(1);
            float lineLength = Vector3.Distance(zero, one);
            lineLength *= 2f;

            rb.AddForce(mouseDirection * lineLength, ForceMode2D.Impulse);
            lr.enabled = false;
        }

    }
}