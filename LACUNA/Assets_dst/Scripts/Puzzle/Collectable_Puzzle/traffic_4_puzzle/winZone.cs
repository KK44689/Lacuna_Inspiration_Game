using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZone : MonoBehaviour
{
    public GameObject puzzle;
    public GameObject puzzleCollider;

    bool target_block_enter = false;

    void Update()
    {
        if (target_block_enter)
        {
            print("win");
            GenCollectable.challangeSolved = true;
            puzzleCollider.GetComponent<BoxCollider2D>().enabled = false;
            puzzle.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "target_block")
        {
            target_block_enter = true;
        }
    }
}
