using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrapScenes : MonoBehaviour
{
    public GameObject Item;

    public int sceneIndex;

    private bool isTrigger;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigger)
        {
            Item.SetActive(false);
            warp();
        }
    }

    public void warp()
    {
        Debug.Log("loading..." + sceneIndex);
        SceneManager.LoadScene (sceneIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Item.SetActive(true);
            isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Item.SetActive(false);
            isTrigger = false;
        }
    }
}
