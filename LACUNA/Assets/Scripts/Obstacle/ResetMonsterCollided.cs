using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetMonsterCollided : MonoBehaviour
{
    public GameObject enemy;

    public GameObject Log;

    public GameObject blankLog;

    public GameObject RefreshButton;

    private bool alreadyBlank = false;

    // load/save variables
    [SerializeField]
    private ObstacleData ObstacleData;

    void Start()
    {
        if (this.alreadyBlank)
        {
            GameObject BlankLog =
                Instantiate(blankLog,
                Log.transform.position,
                Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            enemy.SetActive(false);
            RefreshButton.SetActive(true);
            GameObject BlankLog =
                Instantiate(blankLog,
                Log.transform.position,
                Quaternion.identity);
            this.alreadyBlank = true;
            ObstacleData.blankLogActive = alreadyBlank;
            Destroy (Log);
            Destroy (gameObject);
        }
    }
}
