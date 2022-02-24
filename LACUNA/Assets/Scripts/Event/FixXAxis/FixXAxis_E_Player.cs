using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixXAxis_E_Player : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // make E button not inverse on player
        Vector2 temp = transform.localScale;
        if (player.transform.localScale.x > 0)
        {
            temp.x = 0.01f;
        }
        else
        {
            temp.x = -0.01f;
        }
        transform.localScale = temp;
    }
}
