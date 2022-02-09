using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixXAxis_E : MonoBehaviour
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
        Vector2 temp = transform.localScale;
        if (npc.transform.localScale.x > 0)
        {
            temp.x = 0.008f;
        }
        else
        {
            temp.x = -0.008f;
        }
        transform.localScale = temp;
    }
}
