using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToAnother : MonoBehaviour
{
    [SerializeField]
    int SceneID;

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneID);
    }
}
