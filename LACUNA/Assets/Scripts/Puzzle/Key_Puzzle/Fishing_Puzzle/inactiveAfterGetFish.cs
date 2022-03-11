using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inactiveAfterGetFish : MonoBehaviour
{
    public GameObject NextCollider;

    [SerializeField]
    private int fishCaught = 5;

    // load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        FishingPuzzle.fishingComplete = PuzzleData.fishing_puzzle_solved;
    }

    // Update is called once per frame
    void Update()
    {
        if (FishingPuzzle.score == fishCaught && FishingPuzzle.fishingComplete == false)
        {
            FishingPuzzle.fishingComplete = true;
            PuzzleData.fishing_puzzle_solved = FishingPuzzle.fishingComplete;
            NextCollider.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
