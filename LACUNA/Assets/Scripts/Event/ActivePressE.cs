using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePressE : MonoBehaviour
{
    public GameObject talkText;

    public GameObject collider;

    public string charType;
    bool charEnter = false;

    // Start is called before the first frame update
    void Start()
    {
        collider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && charEnter)
            {
                print("test");
                talkText.SetActive(false);
                collider.SetActive(true);
            }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            talkText.SetActive(true);
            charEnter = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            talkText.SetActive(false);
            charEnter = false;
        }
    }
}
