using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_ActiveNextCollider : MonoBehaviour
{
    public GameObject NextCollider;

    public string charType;

    // active collider when character collide
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(charType))
        {
            NextCollider.SetActive(true);
        }
    }
    // void OnTriggerExit2D(Collider2D collision)
    // {
    //     if (collision.gameObject.tag.Equals(charType))
    //     {
    //         NextCollider.SetActive(false);
    //     }
    // }
}
