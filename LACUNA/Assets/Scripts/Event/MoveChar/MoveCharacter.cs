using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public GameObject Character;

    public string posName;

    public string charType;

    bool Return = false;

    // Update is called once per frame
    void Update()
    {
        GameObject destinationPoint = GameObject.Find(posName);
        // move character to position
        if (Return)
        {
            Character.transform.position = destinationPoint.transform.position;
            Return = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            Return = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            Return = false;
        }
    }
}
