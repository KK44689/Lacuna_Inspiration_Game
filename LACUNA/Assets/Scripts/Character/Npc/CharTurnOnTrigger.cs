using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTurnOnTrigger : MonoBehaviour
{
    public GameObject character;

    private void OnTriggerEnter2D(Collider2D other)
    {
        character.transform.localScale =
            new Vector3(-character.transform.localScale.x,
                character.transform.localScale.y,
                character.transform.localScale.z);
    }
}
