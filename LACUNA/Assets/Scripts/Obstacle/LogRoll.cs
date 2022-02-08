using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogRoll : MonoBehaviour
{
    public GameObject Log;

    public GameObject enemy;

    // public static bool monsterFall = false;
    public Button RefreshButton;

    Rigidbody2D rb2D;

    public static bool stopRolling = false;

    public static bool hitFloor = false;

    public static bool hitEnemy = false;

    public static Vector2 startPos;

    float delayLog = 2f;

    // // Start is called before the first frame update
    void Start()
    {
        stopRolling = false;
        hitEnemy = false;
        startPos = transform.position;
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        RefreshButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (LogCollider.hideLog && (stopRolling == false))
        {
            Log.SetActive(false);
            Physics2D
                .IgnoreCollision(enemy.GetComponent<Collider2D>(),
                GetComponent<Collider2D>(),
                false);

            rb2D.AddForce(transform.right * 5f);
        }
        if (hitFloor)
        {
            print("hit floor");
            stopRolling = true;
            RefreshButton.gameObject.SetActive(true);
            rb2D.Sleep();

            Physics2D
                .IgnoreCollision(enemy.GetComponent<Collider2D>(),
                GetComponent<Collider2D>());
        }
        if (hitEnemy)
        {
            print("hit enemy");
            hitFloor = false;
            RefreshButton.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            hitEnemy = true;

            if (delayLog > 0)
            {
                delayLog -= Time.deltaTime;
            }
            else
            {
                stopRolling = true;
            }
        }
    }
}
