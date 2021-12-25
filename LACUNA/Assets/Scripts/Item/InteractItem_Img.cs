using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractItem_Img : MonoBehaviour
{
    public GameObject talkText;
    public GameObject Image;
    public DialogueTrigger trigger;

    private bool isTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigger)
        {
            talkText.SetActive(false);
            Image.SetActive(true);
            trigger.StartDialogue();
            // Image.SetActive(false);
        }
        if(DialogueManager.isActive == false){
            Image.SetActive(false);
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
