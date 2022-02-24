using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    // Gameobject variables
    private Rigidbody2D rigidbody2d;

    private GameObject pandora;

    public GameObject talkText;

    // Npc movement variables
    public static int direction = 1;

    private float speed = 8.4f;

    private int lookDirecTemp = 1;

    public static bool move = false;

    public static bool moveNotWait = false;

    private Vector2 position;

    private Transform pandoraTransform;

    private Vector2 pandoraPosition;

    // Animation variables
    Animator animator;

    // load/save variables
    [SerializeField]
    private NpcData NpcData;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        talkText.SetActive(false);

        animator = gameObject.GetComponent<Animator>();

        // make npc position equals data
        Vector3 temp = transform.position;
        temp.x = NpcData.position_npc_x;
        transform.position = temp;
    }

    void Update()
    {
        // save data
        NpcData.position_npc_x = transform.position.x;
        // Debug.Log(NpcData.position_npc_x);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pandora = GameObject.FindWithTag("Player");

        position = rigidbody2d.position;

        pandoraTransform = pandora.transform;

        pandoraPosition = pandoraTransform.position;

        // npc move but wait for player
        if (move)
        {
            NpcMove (direction);
        } // npc move and not wait for player
        else if (moveNotWait)
        {
            NpcMoveNotWait (direction);
        }
        else
        {
            // turn npc face direction to player direction
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
        // npc move to the right
        if (direction > 0)
        {
            lookDirection(-1);
            lookDirecTemp = -1;

            // npc wait for player
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
        } // npc move to the left
        else if (direction < 0)
        {
            // print("grandma left");
            lookDirection(1);
            lookDirecTemp = 1;

            // npc wait for player
            if (position.x < (pandoraPosition.x + (5f * direction)))
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
        else
        {
            lookDirection (lookDirecTemp);
            animator.SetBool("walk", false);
        }
    }

    void NpcMoveNotWait(int direction)
    {
        // npc move to the right
        if (direction > 0)
        {
            lookDirection(-1);
            lookDirecTemp = -1;
            animator.SetBool("walk", true);
            position.x = position.x + speed * Time.deltaTime * direction;
            rigidbody2d.MovePosition (position);
        } // npc move to the left
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
        }
    }

    // conrtol look direction
    void lookDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;
        tempScale.x = direction;
        transform.localScale = tempScale;
    }
}
