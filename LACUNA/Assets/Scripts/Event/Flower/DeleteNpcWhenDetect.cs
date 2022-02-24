using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNpcWhenDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("NPC"))
        {
            // active npc when all flower collected
            if (DestroyFlowerUI.flowerAllCollected == false)
            {
                GameObject temp;
                temp = GameObject.FindWithTag("NPC");
                temp.SetActive(false);
            }
        }
    }
}
