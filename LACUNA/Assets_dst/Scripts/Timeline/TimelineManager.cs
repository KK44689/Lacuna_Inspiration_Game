using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    public GameObject UI_interface;
    public GameObject director;
    public int time_director;

    //if rutcutscene finished , then run this object
    public GameObject enter_box;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //when trigger player disable UI_interface
        if (collision.gameObject.tag.Equals("Player")) {
            UI_interface.SetActive(false);
            // Play Cutscenes
            director.SetActive(true);
            Debug.Log("PlayableDirector named" + director.name + "is now playing.");
            StartCoroutine(FinishCut());
        }
        
    }

    IEnumerator FinishCut() {
        yield return new WaitForSecondsRealtime(time_director);
        UI_interface.SetActive(true);
        director.SetActive(false);
        enter_box.SetActive(true);
    }


    // run cutscenes once , dont play again 
    // maybe run cutscenes in orderss
    
}
