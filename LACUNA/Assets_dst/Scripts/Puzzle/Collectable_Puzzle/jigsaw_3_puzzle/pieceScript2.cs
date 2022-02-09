using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieceScript2 : MonoBehaviour
{
    public Vector3 RightPosition;
    public Transform rightPos;
    public Transform leftPos;
    public Transform topPos;
    public Transform bottomPos;

    public bool InRightPosition;

    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position =
            new Vector3(Random.Range(leftPos.position.x, rightPos.position.x), Random.Range(bottomPos.position.y, topPos.position.y));
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
                this.InRightPosition = true;
                GetComponent<SortingGroup>().sortingOrder = 1;
            }
        }
    }
}
