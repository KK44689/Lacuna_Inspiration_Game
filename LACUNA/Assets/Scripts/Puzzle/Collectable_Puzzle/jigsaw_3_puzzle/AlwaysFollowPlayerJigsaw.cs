using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysFollowPlayerJigsaw : MonoBehaviour
{
    GameObject pandora;
    // Start is called before the first frame update
    void Start()
    {
        pandora = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pandora.transform.position.x-5f,3f);
    }
}
