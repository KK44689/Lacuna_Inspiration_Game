using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // enemy movement variables
    public float speed;

    public float chaseSpeed;

    public float distance;

    private bool mustPatrol;

    private bool mustDetect;

    bool movingRight = true;

    public GameObject

            startPos,
            stopPos;

    // gameobject variables
    public static bool monsterInactive = false;

    public GameObject pandora;

    private Rigidbody2D rb;

    Vector3 localScale;

    public float monSize = 0.5f;

    // gameover variables
    public GameObject gameOver;

    public static bool gameover = false;

    public float attackRange;

    // animation variables
    Animator animator;

    // load/save variables
    [SerializeField]
    private MonsterData MonsterData;

    void Start()
    {
        mustPatrol = true;
        mustDetect = true;
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        // make monster position equals data
        // position
        Vector3 temp = transform.position;
        temp.x = MonsterData.monsterPos;
        transform.position = temp;

        // is active
        gameObject.SetActive(MonsterData.monsterActive);

        // monster must detect player
        mustDetect = MonsterData.monsterMustDetect;

        // monster walk
        mustPatrol = MonsterData.monsterMustPatrol;
    }

    void Update()
    {
        float distanceToPlayer =
            Vector2.Distance(transform.position, pandora.transform.position);
        ReturnToStartPoint();

        // Attack player when player in attack range
        if ((distanceToPlayer < attackRange) && mustDetect)
        {
            if (gameObject.name == "Monster03" || gameObject.name == "Monster04"
            )
            {
                if ((transform.position.y > pandora.transform.position.y))
                {
                    monsterWalk();
                }
                else
                {
                    ChasePlayer();
                }
            }
            else
            {
                ChasePlayer();
            }
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
            if (mustPatrol)
            {
                monsterWalk();
            }
            else
            {
                // make monster inactive
                mustDetect = false;
                animator.SetBool("walk", false);
                monsterInactive = true;
                RotateMonster();
                Physics2D
                    .IgnoreCollision(pandora.GetComponent<Collider2D>(),
                    GetComponent<Collider2D>());
                rb.Sleep();
            }
        }
        // save data
        MonsterData.monsterPos = transform.position.x;
        MonsterData.monsterMustDetect = mustDetect;
        MonsterData.monsterMustPatrol = mustPatrol;
        MonsterData.monsterActive = gameObject.activeInHierarchy;
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
        localScale.x = monSize;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }

    void MoveLeft()
    {
        movingRight = false;
        localScale.x = -monSize;
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
            transform.localScale = new Vector2(monSize, monSize);
        }
        else
        {
            print("detect right");

            //enemy on the right side of player move left
            rb.velocity = new Vector2(-chaseSpeed, 0);
            transform.localScale = new Vector2(-monSize, monSize);
        }
    }

    void ReturnToStartPoint()
    {
        // monster return to start position when player gameover
        if (ReturnToCheckPoint.ReturnCheckPoint)
        {
            transform.position = startPos.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // when player collide with monster -> gameover
        if (collision.gameObject.tag.Equals("Player") && gameover == false)
        {
            gameover = true;
            gameOver.SetActive(true);

            if (gameObject.name == "Monster02")
            {
                ReturnToCheckPoint.checkPoint = "checkpoint1";
            }
            else
            {
                ReturnToCheckPoint.checkPoint = "checkpoint2";
            }
        }

        // log collide with monster -> monster inactive
        if (collision.gameObject.tag.Equals("Log") && gameover == false)
        {
            mustPatrol = false;
        }
    }
}
