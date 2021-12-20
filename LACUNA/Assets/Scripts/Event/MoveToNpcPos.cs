using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNpcPos : MonoBehaviour
{
    GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        npc = GameObject.FindWithTag("NPC");
        transform.position = npc.transform.position;
    }
}
