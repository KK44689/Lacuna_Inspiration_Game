using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFlowerTutorial : MonoBehaviour
{
    public static bool flowerTutorialAwake = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        // active flower tutorial
        if (collider.gameObject.tag.Equals("NPC"))
        {
            flowerTutorialAwake = true;
        }
    }
}
