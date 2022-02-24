using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalkingLeft : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // when collide npc move to the left and wait for player
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.move = true;
            NpcController.direction = -1;
        }
    }
}
