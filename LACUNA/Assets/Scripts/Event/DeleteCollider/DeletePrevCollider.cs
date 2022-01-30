using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrevCollider : MonoBehaviour
{
    public GameObject PrevCollider;

    public string characterType;

    // Start is called before the first frame update
    // void Awake()
    // {
    //     PrevCollider.SetActive(false);
    // }
    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals(characterType))
        {
            PrevCollider.SetActive(false);
        }
    }
}
