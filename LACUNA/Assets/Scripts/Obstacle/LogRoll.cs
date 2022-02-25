using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogRoll : MonoBehaviour
{
    public GameObject Log;

    public GameObject enemy;

    public Button RefreshButton;

    Rigidbody2D rb2D;

    public static bool stopRolling = false;

    public static bool hitFloor = false;

    public static bool hitEnemy = false;

    public static Vector2 startPos;

    float delayLog = 2f;

    // load/save variables
    [SerializeField]
    private ObstacleData ObstacleData;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb2D = GetComponent<Rigidbody2D>();
        RefreshButton.gameObject.SetActive(false);

        // variable equals data
        // stopRolling = false;
        // hitEnemy = false;
        stopRolling = ObstacleData.logRollStop;
        hitEnemy = ObstacleData.logRollHitEnemy;
        hitFloor = ObstacleData.logRollHitFloor;
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

            rb2D.AddForce(transform.right * 500f);
        }
        if (hitFloor)
        {
            stopRolling = true;
            RefreshButton.gameObject.SetActive(true);
            rb2D.Sleep();

            Physics2D
                .IgnoreCollision(enemy.GetComponent<Collider2D>(),
                GetComponent<Collider2D>());
        }
        if (hitEnemy)
        {
            hitFloor = false;
            RefreshButton.gameObject.SetActive(false);
        }
        ObstacleData.logRollStop = stopRolling;
        ObstacleData.logRollHitEnemy = hitEnemy;
        ObstacleData.logRollHitFloor = hitFloor;
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
