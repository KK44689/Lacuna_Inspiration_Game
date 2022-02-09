using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    
    // Quaternion tempRotation;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    //     tempRotation = transform.rotation;
    // }

    // // // Update is called once per frame
    // void Update()
    // {
    //     transform.rotation =
    //         Quaternion
    //             .RotateTowards(transform.rotation,
    //             tempRotation,
    //             Time.deltaTime * 2f);
    // }

    public void rotate()
    {
        transform.Rotate(Vector3.forward, -45f, Space.Self);
        Debug.Log(gameObject.name);
    }
}
