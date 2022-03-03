using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    public GameObject UI_interface;

    public GameObject obj_cut;
    public GameObject director;
    public int time_director;

    //if rutcutscene finished , then run this object
    //enter_box and warp object
    public GameObject enter_box;

    //bool data
    private bool bool_UI;
    private bool bool_obj_cut;
    private bool bool_director;
    private bool bool_enter_box;
 

    [SerializeField]
    public CutsceneData cutsceneData;

    public void Start()
    {
        bool_UI = cutsceneData.UI_active;
        bool_director = cutsceneData.cutscene_active;
        bool_enter_box = cutsceneData.enter_box_active;
        bool_obj_cut = cutsceneData.obj_cut_active;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //when trigger player disable UI_interface
        if (collision.gameObject.tag.Equals("Player")) {
            UI_interface.SetActive(false);

            // Play Cutscenes
            director.SetActive(true);

            //set bool to update change
            bool_UI = false;
            bool_director = true;
           

            Debug.Log("PlayableDirector named" + director.name + "is now playing.");
            StartCoroutine(FinishCut());
        }
        
    }

    IEnumerator FinishCut() {
        yield return new WaitForSecondsRealtime(time_director);
        UI_interface.SetActive(true);
        director.SetActive(false);

        //open warp after cutscene
        enter_box.SetActive(true);

        //set bool to update change
        bool_UI = true;
        bool_director = false;
        bool_enter_box = true;
        bool_obj_cut = false;
    }


    // run cutscenes once , dont play again 
    // maybe run cutscenes in orderss


    //use for checkpoint_cutscene and cutscene then open warp
    public void Update()
    {
        // the method split data to every cutscenes

        cutsceneData.UI_active = bool_UI;
        cutsceneData.obj_cut_active = bool_obj_cut;
        cutsceneData.cutscene_active = bool_director;
        cutsceneData.enter_box_active = bool_enter_box;

        if (cutsceneData.UI_active == true)
        {
            UI_interface.SetActive(true);
        }
        else {
            UI_interface.SetActive(false);
        }


        if (cutsceneData.obj_cut_active == true)
        {
            obj_cut.SetActive(true);
        }
        else {
            obj_cut.SetActive(false);
        }


        if (cutsceneData.cutscene_active == true)
        {
            director.SetActive(true);
        }
        else {
            director.SetActive(false);
        }


        if (cutsceneData.enter_box_active == true)
        {
            enter_box.SetActive(true);
        }
        else {
            enter_box.SetActive(false);
        }


        //last: true false true


        // for loop check each one will be false ??
        //if (cutsceneData.bool_cutscenes[0] == false) {
        //
        //cutsceneData.GameObjects_cutscenes set active false;
        //    cutsceneData.GameObjects_cutscenes[0].SetActive(false);
        //}else(cutsceneData.bool_cutscenes[0] == true){
        //    cutsceneData.GameObjects_cutscenes[0].SetActive(true);
        //}
    }

}
