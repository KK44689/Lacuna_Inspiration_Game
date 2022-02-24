using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDetect : MonoBehaviour
{
    public DialogueTrigger trigger;
    public string charType;

    // start dialogue on collide
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            trigger.StartDialogue();
        }
    }
}
