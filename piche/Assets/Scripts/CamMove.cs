using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothing;

    public PlayerMove pm;

    /*private void Start()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerMove>();
    }
    */
    /*private void Update()
    {
        Debug.Log(pm.GetStartPoint());
    }
    */
    private void LateUpdate()
    {
        /*if (Input.GetMouseButton(0))
        {
            if(pm.GetStartPoint() != Vector3.zero)
            {
                offset = pm.GetStartPoint().normalized;
                transform.position = offset;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            offset = Vector3.zero;
            
        }
        */
        transform.position = Vector3.Lerp(transform.position, player.position + offset, smoothing);
    }

}
