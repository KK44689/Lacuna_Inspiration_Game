using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollider : MonoBehaviour
{
    public GameObject pickUpText;

    public GameObject logRoll;

    public static bool hideLog = false;

    bool pickUpAllowed;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.SetActive(false);
        logRoll.SetActive(false);
        hideLog = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (
            pickUpAllowed &&
            Input.GetKeyDown(KeyCode.E) &&
            PuzzleCollider.alreadyPickup
        )
        {
            LogRoll.hitFloor = false;
            LogRoll.hitEnemy = false;
            logRoll.SetActive(true);
            hideLog = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (
            collision.gameObject.tag.Equals("Player") &&
            PuzzleCollider.alreadyPickup
        )
        {
            pickUpText.SetActive(true);
            pickUpAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(false);
            pickUpAllowed = false;
        }
    }
}
