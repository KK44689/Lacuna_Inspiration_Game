using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAfterSolvedPuzzle : MonoBehaviour
{
    public GameObject puzzleDetector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GenCollectable.challangeSolved){
            puzzleDetector.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
