using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wrap : MonoBehaviour
{
    public int currentScene;
    public int sceneTo;

    [SerializeField]
    private IndexSceneData IndexSceneData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        warp();
    }

    public void warp()
    {
        Debug.Log("loading..." + sceneTo);
        SceneManager.LoadScene(sceneTo);
    }

    public void Update()
    {
        //PlayerPrefs.SetInt("currentSceneIndex", sceneIndex);


        // do another method 
        // save in SystemData.currentSceneIndex 
        IndexSceneData.currentSceneIndex = currentScene;
        Debug.Log(IndexSceneData.currentSceneIndex);
    }
}
