using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;

    public Text actorName;

    public Text messageText;

    public RectTransform backgroundBox;

    Message[] currentMessages;

    Actor[] currentActors;

    public static int activeMessage = 0;

    public static int currentMessagesLength;

    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        // start dialogue
        currentMessages = messages;
        currentMessagesLength = currentMessages.Length;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;

        // Debug.Log("started conversation ! Loaded messages" + messages.Length);
        DisplayMessage();

        // dialogue box move in
        backgroundBox.LeanScale(new Vector3(1f, 1f, 1f), 1f).setEaseInOutExpo();
    }

    void DisplayMessage()
    {
        // show text in dialogue box
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }

    public void NextMessage()
    {
        // move to next dialogue
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            // Debug.Log("Conversation ended!");
            isActive = false;

            // dialogue box move out
            backgroundBox.LeanScale(Vector3.zero, 1f).setEaseInOutExpo();
        }
    }

    void AnimateTextColor()
    {
        // text fade when change to next text
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.8f);
    }

    // Start is called before the first frame update
    void Start()
    {
        // hide dialogue box
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // move to next text after press spacebar
        if (Input.GetKeyDown(KeyCode.Space) && isActive)
        {
            NextMessage();
        }
    }
}
