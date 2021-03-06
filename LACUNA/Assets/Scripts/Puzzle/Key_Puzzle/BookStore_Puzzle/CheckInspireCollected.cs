using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInspireCollected : MonoBehaviour
{
    public GameObject PuzzleCollider;

    [SerializeField]
    private PuzzleData PuzzleData;

    // Start is called before the first frame update
    void Start()
    {
        PuzzleCollider.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleData.inspireItem_alreadyPicked)
        {
            PuzzleCollider.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
