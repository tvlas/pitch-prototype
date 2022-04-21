using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothing;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            offset[0] = 1;
        }
        if (Input.GetMouseButtonUp(0)){
            offset[0] = 0;
        }
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + offset, smoothing);
    }

}
