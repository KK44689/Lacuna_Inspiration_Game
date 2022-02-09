using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixXAxis_Player2 : MonoBehaviour
{
    GameObject player;
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = transform.localScale;
        if (player.transform.localScale.x > 0)
        {
            temp.x = scale;
        }
        else
        {
            temp.x = -scale;
        }
        transform.localScale = temp;
    }
}
