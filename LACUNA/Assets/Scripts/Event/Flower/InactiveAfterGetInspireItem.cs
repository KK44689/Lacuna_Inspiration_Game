using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAfterGetInspireItem : MonoBehaviour
{
    public GameObject Button;

    [SerializeField]
    private PuzzleData PuzzleData;

    // Update is called once per frame
    void Update()
    {
        if (PuzzleCollider.alreadyPickup || PuzzleData.inspireItem_alreadyPicked
        )
        {
            Button.SetActive(false);
        }
    }
}
