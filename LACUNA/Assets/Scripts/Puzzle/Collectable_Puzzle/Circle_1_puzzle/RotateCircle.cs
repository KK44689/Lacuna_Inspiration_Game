using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public void rotate()
    {
        transform.Rotate(Vector3.forward, -45f, Space.Self);
        Debug.Log(gameObject.name);
    }
}
