using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, 0.1f);
    }
}
