using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAllLibraryPuzzleSolved : MonoBehaviour
{
    public GameObject collider;
    [SerializeField]
    private PuzzleData PuzzleData;

    // Update is called once per frame
    void Update()
    {
        if(PuzzleData.all_puzzle_solved){
            collider.SetActive(true);
        }
    }
}
