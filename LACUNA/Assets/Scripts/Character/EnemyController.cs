using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    public float chaseSpeed;

    public float distance;

    private bool mustPatrol;

    private bool mustDetect;

    // private bool flip;
    public GameObject pandora;

    public GameObject gameOver;

    // public static bool monsterFall = false;

    public GameObject

            startPos,
            stopPos;

    bool movingRight = true;

    Vector3 localScale;

    public float attackRange;

    private Rigidbody2D rb;

    Animator animator;

    public static bool gameover = false;

    void Start()
    {
        mustPatrol = true;
        mustDetect = true;
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        // startPos = GameObject.Find("startPos").GetComponent<Transform>();
        // stopPos = GameObject.Find("stopPos").GetComponent<Transform>();
    }

    void Update()
    {
        float distanceToPlayer =
            Vector2.Distance(transform.position, pandora.transform.position);
        ReturnToStartPoint();
        if (distanceToPlayer < attackRange && mustDetect)
        {
            ChasePlayer();
        }
        else
        {
            rb.velocity = new Vector2(0, 0);

            // detectedPlayer = false;
            if (mustPatrol)
            {
                monsterWalk();
            }
            else
            {
                mustDetect = false;
                animator.SetBool("walk", false);
                RotateMonster();
                Physics2D
                    .IgnoreCollision(pandora.GetComponent<Collider2D>(),
                    GetComponent<Collider2D>());
                rb.Sleep();
            }
        }
    }

    void monsterWalk()
    {
        animator.SetBool("walk", true);

        Vector2 position = rb.position;

        if (position.x < startPos.transform.position.x)
        {
            movingRight = true;
        }
        if (position.x > stopPos.transform.position.x)
        {
            movingRight = false;
        }

        if (movingRight)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }
    }

    void MoveRight()
    {
        movingRight = true;
        localScale.x = 0.5f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }

    void MoveLeft()
    {
        movingRight = false;
        localScale.x = -0.5f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }

    void RotateMonster()
    {
        transform.eulerAngles = new Vector3(0, 0, -90);
    }

    void ChasePlayer()
    {
        if (transform.position.x < pandora.transform.position.x)
        {
            print("detect left");

            //enemy on the left side of player move right
            rb.velocity = new Vector2(chaseSpeed, 0);
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
        else
        {
            print("detect right");

            //enemy on the right side of player move left
            rb.velocity = new Vector2(-chaseSpeed, 0);
            transform.localScale = new Vector2(-0.5f, 0.5f);
        }
    }

    void ReturnToStartPoint()
    {
        if (ReturnToCheckPoint.ReturnCheckPoint)
        {
            transform.position = startPos.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && gameover == false)
        {
            gameover = true;
            gameOver.SetActive(true);
            if(gameObject.name == "Monster02"){
                ReturnToCheckPoint.checkPoint = "checkpoint1";
            }
            else{
                ReturnToCheckPoint.checkPoint = "checkpoint2";
            }
            // gameObject.transform.position = stopPos.transform.position;
        }
        if (collision.gameObject.tag.Equals("Log") && gameover == false)
        {
            mustPatrol = false;
        }
    }
}
