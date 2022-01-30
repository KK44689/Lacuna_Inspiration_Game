using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNextAfterConver : MonoBehaviour
{
    public GameObject NextCollider;

    public string characterType;

    bool charEnter = false;

    // Start is called before the first frame update
    void start()
    {
        NextCollider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (
            !(
            DialogueManager.activeMessage <
            DialogueManager.currentMessagesLength
            ) &&
            charEnter
        )
        {
            NextCollider.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals(characterType))
        {
            charEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals(characterType))
        {
            charEnter = false;
        }
    }
}
