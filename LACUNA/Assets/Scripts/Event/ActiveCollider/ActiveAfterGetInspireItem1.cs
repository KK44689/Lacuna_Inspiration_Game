using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterGetInspireItem1 : MonoBehaviour
{
    public GameObject collider;

    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        collider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // player collect inspire item -> active collider (chapter 2,3,4)
        if (
            // GenInspireItem.inspireItemPicked &&
            PuzzleData.inspireItem_puzzle_solved
        )
        {
            collider.SetActive(true);
        }
    }
}
