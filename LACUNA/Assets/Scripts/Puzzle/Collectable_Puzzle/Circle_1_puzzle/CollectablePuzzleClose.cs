using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePuzzleClose : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (CollectableDetecter.showPuzzle && Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
}
