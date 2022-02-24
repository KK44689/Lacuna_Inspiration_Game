using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalkingRight : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // when collide npc move to the right and wait for player
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.move = true;
            NpcController.direction = 1;
        }
    }
}
