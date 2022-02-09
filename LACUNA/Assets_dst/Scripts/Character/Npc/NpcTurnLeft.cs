using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTurnLeft : MonoBehaviour
{
    GameObject npc;

    // Start is called before the first frame update
    void Start()
    {
        npc = GameObject.FindWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempScale = npc.transform.localScale;
        tempScale.x = -1;
        npc.transform.localScale = tempScale;
    }
}
