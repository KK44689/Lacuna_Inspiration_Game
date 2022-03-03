using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAfterCollectableSolved : MonoBehaviour
{
    public GameObject puzzleDetector;

    // Update is called once per frame
    void Update()
    {
        if (GenCollectable.challangeSolved)
        {
            puzzleDetector.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
