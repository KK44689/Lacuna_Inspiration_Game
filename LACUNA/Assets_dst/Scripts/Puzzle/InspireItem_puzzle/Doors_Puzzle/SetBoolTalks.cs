using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoolTalks : MonoBehaviour
{
    public bool kid_talk;
    bool charEnter = false;
    // Start is called before the first frame update
    void Start()
    {
        this.kid_talk = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.charEnter && Input.GetKeyDown(KeyCode.E)){
            print(this.name);
            this.kid_talk = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            this.charEnter = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            this.charEnter = false;
        }
    }
}
