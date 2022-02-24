using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAfterGetInspireItem : MonoBehaviour
{
    public GameObject Button;

    // Update is called once per frame
    void Update()
    {
        if (PuzzleCollider.alreadyPickup)
        {
            Button.SetActive(false);
        }
    }
}
