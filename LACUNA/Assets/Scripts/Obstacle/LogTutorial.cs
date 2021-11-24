using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTutorial : MonoBehaviour
{
    public GameObject tutorialText;
    // bool pickUpAllowed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyController.monsterInactive)
        {
            tutorialText.SetActive(false);
        }
    }

    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (
    //         collision.gameObject.tag.Equals("Player") &&
    //         PuzzleCollider.alreadyPickup
    //     )
    //     {
    //         pickUpAllowed = true;
    //     }
    // }
}
