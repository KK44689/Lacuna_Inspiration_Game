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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy (enemy);
            RefreshButton.SetActive(true);
            GameObject BlankLog =
                Instantiate(blankLog,
                Log.transform.position,
                Quaternion.identity);
            Destroy (Log);
            Destroy (gameObject);
        }
    }
}
