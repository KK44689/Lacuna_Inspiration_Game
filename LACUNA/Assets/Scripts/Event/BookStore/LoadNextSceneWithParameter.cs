using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneWithParameter : MonoBehaviour
{
    [SerializeField]
    int sceneID;

    [SerializeField]
    float delay;

    bool startFade = false;

    void Update()
    {
        StaticClass.CrossSceneInformation =
            CheckAllBookStorePuzzleSolved.allBookStorePuzzleSolved;
        if (startFade)
        {
            if (delay > 0)
            {
                delay -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene (sceneID);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        startFade = true;
    }
}

public static class StaticClass
{
    public static bool CrossSceneInformation { get; set; }
}
