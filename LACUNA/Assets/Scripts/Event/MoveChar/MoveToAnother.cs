using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToAnother : MonoBehaviour
{
    [SerializeField]
    int SceneID;

    [SerializeField]
    float delay;

    bool LoadNextSceneAllow = false;

    private void Update()
    {
        if (delay > 0)
        {
            delay-= Time.deltaTime;
            print(delay);
            return;
        }
        else
        {
            print("change");
            SceneManager.LoadScene (SceneID);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.LoadNextSceneAllow = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        this.LoadNextSceneAllow = false;
    }
}
