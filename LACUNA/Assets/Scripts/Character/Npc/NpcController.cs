using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    GameObject pandora;

    public static int direction = 1;

    // public static int sceneID = 0;
    float speed = 8.4f;

    public GameObject talkText;

    // public GameObject dialogueBox;
    int lookDirecTemp = 1;

    // bool talking = false;
    // bool StopTalking = false;
    // bool endText = false; // for test
    public static bool move = false; // for test

    public static bool moveNotWait = false; // for test

    Animator animator;

    Vector2 position;

    Transform pandoraTransform;

    Vector2 pandoraPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        talkText.SetActive(false);

        // dialogueBox.SetActive(false);
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pandora = GameObject.FindWithTag("Player");

        position = rigidbody2d.position;

        pandoraTransform = pandora.transform;

        pandoraPosition = pandoraTransform.position;

        if (move)
        {
            NpcMove (direction);
        }
        else if (moveNotWait)
        {
            NpcMoveNotWait (direction);
        }
        else
        {
            // Vector2 position = rigidbody2d.position;
            // pandora = GameObject.FindWithTag("Player");
            // Transform pandoraTransform = pandora.transform;
            // Vector2 pandoraPosition = pandoraTransform.position;
            if (pandoraPosition.x >= position.x)
            {
                lookDirection(-1);
            }
            else if (pandoraPosition.x < position.x)
            {
                lookDirection(1);
            }
            animator.SetBool("walk", false);
            return;
        }
    }

    void NpcMove(int direction)
    {
        // Vector2 position = rigidbody2d.position;
        // pandora = GameObject.FindWithTag("Player");

        // pandora = GameObject.FindWithTag("Player");
        // Transform pandoraTransform = pandora.transform;
        // Vector2 pandoraPosition = pandoraTransform.position;
        if (direction > 0)
        {
            lookDirection(-1);
            lookDirecTemp = -1;

            // print("grandma right");
            // stop waiting for Pandora
            if (Mathf.Abs(position.x) > (pandoraPosition.x + (5f * direction)))
            {
                animator.SetBool("walk", false);
                position.x = position.x + 0 * Time.deltaTime * direction;
            }
            else
            // start walking
            {
                animator.SetBool("walk", true);
                position.x = position.x + speed * Time.deltaTime * direction;
                rigidbody2d.MovePosition (position);
            }
        }
        else if (direction < 0)
        {
            // print("grandma left");
            lookDirection(1);
            lookDirecTemp = 1;
            if (position.x < (pandoraPosition.x + (5f * direction)))
            {
                animator.SetBool("walk", false);
                position.x = position.x + 0 * Time.deltaTime * direction;
            }
            else
            {
                animator.SetBool("walk", true);
                position.x = position.x + speed * Time.deltaTime * direction;
                rigidbody2d.MovePosition (position);
            }
        }
        else
        {
            lookDirection (lookDirecTemp);
            animator.SetBool("walk", false);
            // Debug.Log("idle");
        }
    }

    void NpcMoveNotWait(int direction)
    {
        // Vector2 position = rigidbody2d.position;
        // pandora = GameObject.FindWithTag("Player");
        // Transform pandoraTransform = pandora.transform;
        // Vector2 pandoraPosition = pandoraTransform.position;
        if (direction > 0)
        {
            lookDirection(-1);
            lookDirecTemp = -1;
            animator.SetBool("walk", true);
            position.x = position.x + speed * Time.deltaTime * direction;
            rigidbody2d.MovePosition (position);
        }
        else if (direction < 0)
        {
            lookDirection(1);
            lookDirecTemp = 1;

            animator.SetBool("walk", true);
            position.x = position.x + speed * Time.deltaTime * direction;
            rigidbody2d.MovePosition (position);
        }
        else
        {
            lookDirection (lookDirecTemp);
            animator.SetBool("walk", false);
            // Debug.Log("idle");
        }
    }

    void lookDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;
        tempScale.x = direction;
        transform.localScale = tempScale;
    }
}
