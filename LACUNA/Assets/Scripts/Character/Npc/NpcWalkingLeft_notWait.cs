using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalkingLeft_notWait : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // when collide npc move to the left and not wait for player
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.moveNotWait = true;
            NpcController.move = false;
            NpcController.direction = -1;
            PuzzleCollider.puzzleAwake = true;
        }
    }
}
