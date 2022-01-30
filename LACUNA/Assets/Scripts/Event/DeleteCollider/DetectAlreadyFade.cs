using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAlreadyFade : MonoBehaviour
{
    public GameObject nextCollider;

    // Start is called before the first frame update
    void Start()
    {
        nextCollider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FadeBlack.alreadyFade)
        {
            nextCollider.SetActive(true);
        }
    }
}
