using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate( new Vector3(0, 0, 0.5f) );
    }
}
