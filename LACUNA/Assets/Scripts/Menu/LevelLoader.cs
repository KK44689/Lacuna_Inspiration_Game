using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    public GameObject continueScreen;

    [SerializeField]
    private IndexSceneData indexSceneData;

    //add script NewGameData.cs
    public NewGameData newgame;

    private void Start()
    {
        if (indexSceneData.currentSceneIndex == 0 || indexSceneData.currentSceneIndex == 18)
        {
            continueScreen.SetActive(false);
        }
        else {
            continueScreen.SetActive(true);
        }

    }


    public void Continue() {
        // get current_index and play
        // continue will show when start collecting data process game
        StartCoroutine(LoadAsynchronously(indexSceneData.currentSceneIndex));
    }

    public void NewGame() {

        //start new game

        indexSceneData.currentSceneIndex = 1;
        newgame.StartNewGame();

        StartCoroutine(LoadAsynchronously(indexSceneData.currentSceneIndex));
    }

    public void BackToMenu()
    {

        StartCoroutine(LoadAsynchronously(0));
    }

    IEnumerator LoadAsynchronously (int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / 1.11f);

            slider.value = progress;

            yield return null;
        }
    }
}
