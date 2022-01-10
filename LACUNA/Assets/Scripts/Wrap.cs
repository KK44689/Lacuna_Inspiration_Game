using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wrap : MonoBehaviour
{
    public int sceneIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        warp();
    }

    public void warp()
    {
        Debug.Log("loading..." + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }
}
