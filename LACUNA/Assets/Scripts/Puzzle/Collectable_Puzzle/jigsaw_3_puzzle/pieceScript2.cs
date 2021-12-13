using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieceScript2 : MonoBehaviour
{
    public Vector3 RightPosition;

    public bool InRightPosition;

    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position =
            new Vector3(Random.Range(1166f, 1606f), Random.Range(225f, 870f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 10f)
        {
            // print("right pos");
            if (InRightPosition == false)
            {
                transform.position = RightPosition;
                InRightPosition = true;
                GetComponent<SortingGroup>().sortingOrder = 1;
            }
        }
    }
}
