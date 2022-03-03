using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wrap : MonoBehaviour
{
    public GameObject Warp_obj;
    public int currentScene;
    public int sceneTo;

    [SerializeField]
    private IndexSceneData IndexSceneData;

    [SerializeField]
    private WarpData warpData;

    private bool bool_warp ;

    private void Start()
    {
        bool_warp = warpData.warp_active;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        warp();
        bool_warp = false;
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
        //Debug.Log(IndexSceneData.currentSceneIndex);

        warpData.warp_active = bool_warp;

        if (warpData.warp_active == true)
        {
            Warp_obj.SetActive(true);
        }
        else {
            Warp_obj.SetActive(false);
        }
    }
}
