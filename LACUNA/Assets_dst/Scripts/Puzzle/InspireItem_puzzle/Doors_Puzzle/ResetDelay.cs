using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDelay : MonoBehaviour
{
    public GameObject NextCollider;

    [SerializeField]
    float delay_start;
    float delay;

    private void OnEnable() {
        delay = delay_start;
    }

    // Update is called once per frame
    void Update()
    {
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
