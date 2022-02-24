using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalkingRight_notWait : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // when collide npc move to the right and not wait for player
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.moveNotWait = true;
            NpcController.direction = 1;
        }
    }
}
