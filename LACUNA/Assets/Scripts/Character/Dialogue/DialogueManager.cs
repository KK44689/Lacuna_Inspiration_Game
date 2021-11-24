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

    public void OpenDialogue(Message[] messages,Actor[] actors){
        currentMessages = messages;
        currentMessagesLength = currentMessages.Length;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;

        Debug.Log("started conversation ! Loaded messages" + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(new Vector3(7.93153f,7.93153f,0.881281f),1f).setEaseInOutExpo();
    }

    void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }

    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessages.Length){
            DisplayMessage();
        }
        else{
            Debug.Log("Conversation ended!");
            isActive = false;
            backgroundBox.LeanScale(Vector3.zero,1f).setEaseInOutExpo();
        }
    } 

    void AnimateTextColor(){
        LeanTween.textAlpha(messageText.rectTransform,0,0);
        LeanTween.textAlpha(messageText.rectTransform,1,0.8f);

    }
    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive){
            NextMessage();
        }
    }
}
