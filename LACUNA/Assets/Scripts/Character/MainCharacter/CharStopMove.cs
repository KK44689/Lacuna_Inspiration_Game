using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStopMove : MonoBehaviour
{
    public static bool charStop = false;

    void OnTriggerEnter2D(Collider2D other) {
        charStop = true;
    }
    void OnTriggerExit2D(Collider2D other) {
        charStop = false;
    }
}
