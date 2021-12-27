using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePressE : MonoBehaviour
{
    public GameObject talkText;

    public GameObject collider;

    public string charType;

    // Start is called before the first frame update
    void Start()
    {
        talkText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            talkText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                talkText.SetActive(false);
                collider.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            talkText.SetActive(false);
        }
    }
}
