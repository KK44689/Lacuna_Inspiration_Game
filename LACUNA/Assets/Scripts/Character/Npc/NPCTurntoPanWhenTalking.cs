using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTurntoPanWhenTalking : MonoBehaviour
{
    GameObject pandora;

    Vector2 pandoraPosition;

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.isActive)
        {
            pandora = GameObject.FindWithTag("Player");
            pandoraPosition = pandora.transform.position;
            if (pandoraPosition.x >= transform.position.x)
            {
                Vector3 tempScale = transform.localScale;
                tempScale.x = -1;
                transform.localScale = tempScale;
            }
            else if (pandoraPosition.x < transform.position.x)
            {
                Vector3 tempScale = transform.localScale;
                tempScale.x = 1;
                transform.localScale = tempScale;
            }
            return;
        }
    }
}
