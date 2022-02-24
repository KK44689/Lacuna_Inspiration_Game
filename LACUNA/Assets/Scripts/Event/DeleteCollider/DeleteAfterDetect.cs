using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterDetect : MonoBehaviour
{
    public string charType;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals(charType))
        {
            // inactive character when collide
            other.gameObject.SetActive(false);
        }
    }
}
