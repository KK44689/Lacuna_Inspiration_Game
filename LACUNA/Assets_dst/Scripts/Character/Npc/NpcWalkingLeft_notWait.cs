using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalkingLeft_notWait : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.moveNotWait = true;
            NpcController.move = false;
            NpcController.direction = -1;
            PuzzleCollider.puzzleAwake = true;
        }
    }
}
