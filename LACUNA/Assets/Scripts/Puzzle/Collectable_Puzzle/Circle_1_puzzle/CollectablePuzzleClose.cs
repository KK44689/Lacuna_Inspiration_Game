using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePuzzleClose : MonoBehaviour
{
    // public GameObject Puzzle;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if(CollectableDetecter.showPuzzle && Input.GetKeyDown(KeyCode.Escape)){
            gameObject.SetActive(false);
        }
    }
}
