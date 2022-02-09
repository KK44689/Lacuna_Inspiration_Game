using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDetectPressE : MonoBehaviour
{
    public DialogueTrigger trigger;

    public GameObject talkText;

    bool PlayerEnter = false;

    // Start is called before the first frame update
    void Start()
    {
        talkText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerEnter && Input.GetKeyDown(KeyCode.E))
        {
            trigger.StartDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            PlayerEnter = true;
            talkText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            PlayerEnter = false;
            talkText.SetActive(false);
        }
    }
}
