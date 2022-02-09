using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Log") &&
            collision.gameObject.tag.Equals("Enemy") == false
        )
        {
            LogRoll.hitFloor = true;
        }
    }

}
