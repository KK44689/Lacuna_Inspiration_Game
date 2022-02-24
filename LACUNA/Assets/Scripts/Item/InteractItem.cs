using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractItem : MonoBehaviour
{
    public GameObject talkText;
    public DialogueTrigger trigger;

    private bool isTrigger;
    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigger)
        {
            talkText.SetActive(false);
            trigger.StartDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            talkText.SetActive(true);
            isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            talkText.SetActive(false);
            isTrigger = false;
        }
    }

}
