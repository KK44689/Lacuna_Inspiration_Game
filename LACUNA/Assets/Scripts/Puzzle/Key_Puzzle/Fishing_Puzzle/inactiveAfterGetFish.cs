using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inactiveAfterGetFish : MonoBehaviour
{
    public GameObject NextCollider;

    // Update is called once per frame
    void Update()
    {
        if (FishingPuzzle.score == 10)
        {
            NextCollider.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
