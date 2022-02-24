using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterDelay : MonoBehaviour
{
    public GameObject NextCollider;

    [SerializeField]
    float delay;

    // Update is called once per frame
    void Update()
    {
        // active collider after delays
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            NextCollider.SetActive(true);
        }
    }
}
