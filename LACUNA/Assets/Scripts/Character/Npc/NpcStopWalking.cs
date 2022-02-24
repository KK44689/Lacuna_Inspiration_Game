using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStopWalking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // when npc collide with collider -> npc stop moving
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.move = false;
            NpcController.moveNotWait = false;
        }
    }
}
