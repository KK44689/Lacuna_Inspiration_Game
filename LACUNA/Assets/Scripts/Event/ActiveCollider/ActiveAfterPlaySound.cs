using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterPlaySound : MonoBehaviour
{
    AudioSource audioSource;

    public GameObject nextCollider;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nextCollider.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // active after play sound
        if (!audioSource.isPlaying)
        {
            nextCollider.SetActive(true);
        }
    }
}
