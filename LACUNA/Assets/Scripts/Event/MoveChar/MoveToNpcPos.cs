using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNpcPos : MonoBehaviour
{
    GameObject npc;

    // Update is called once per frame
    void Update()
    {
        // move this gameobject to npc position
        npc = GameObject.FindWithTag("NPC");
        transform.position = npc.transform.position;
    }
}
