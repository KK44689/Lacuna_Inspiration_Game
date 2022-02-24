using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrevCollider : MonoBehaviour
{
    public GameObject PrevCollider;

    public string characterType;

    void OnTriggerEnter2D(Collider2D collider)
    {
        // inactive chosen collider when collide
        if (collider.gameObject.tag.Equals(characterType))
        {
            PrevCollider.SetActive(false);
        }
    }
}
