using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTutorialStop : MonoBehaviour
{
    // detect flower tutorial complete
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("NPC"))
        {
            FlowerTutorial.flowerTutorial_stop = false;
        }
    }
}
