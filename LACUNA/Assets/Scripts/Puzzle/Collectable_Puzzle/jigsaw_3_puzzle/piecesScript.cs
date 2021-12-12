using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piecesScript : MonoBehaviour
{
    private Vector3 RightPosition;

    public bool InRightPosition;

    public bool Selected;

    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position =
            new Vector3(Random.Range(167f, 173f), Random.Range(8.5f, -2.3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                transform.position = RightPosition;
                InRightPosition = true;
            }
        }
    }
}
