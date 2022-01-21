using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCanvasToScreen : MonoBehaviour
{
    private void Update()
    {
        Vector3 temp = Camera.main.transform.position;
        temp.z = 0;
        transform.position = temp;
    }
}
