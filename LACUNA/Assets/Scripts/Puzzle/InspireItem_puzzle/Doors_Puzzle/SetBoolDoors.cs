using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoolDoors : MonoBehaviour
{
    public static int wrong_doors = 0;

    bool charEnter = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (charEnter && Input.GetKeyDown(KeyCode.E))
        {
            wrong_doors++;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            charEnter = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            charEnter = false;
        }
    }
}
