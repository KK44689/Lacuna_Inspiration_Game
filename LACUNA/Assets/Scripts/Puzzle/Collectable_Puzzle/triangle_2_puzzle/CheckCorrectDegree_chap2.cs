using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectDegree_chap2 : MonoBehaviour
{
    // public GameObject checkCollider;
    GameObject eye;
    GameObject heart;
    GameObject brain;
    public GameObject Puzzle;
    public GameObject puzzleDetector;

    float targetDegreesEye = -45f;
    float targetDegreesHeart = 45f;
    float targetDegreesBrain =  -180f;

    bool eye_solved;
    bool heart_solved;
    bool brain_solved;

    void Start()
    {
        eye_solved = false;
        heart_solved = false;
        brain_solved = false;
        eye = GameObject.Find("Eye");
        heart = GameObject.Find("Heart");
        brain = GameObject.Find("Brain");
    }

    void Update()
    {
        CheckCorrectedDegrees();
        CheckAllCorrected();
    }

    void CheckAllCorrected(){
        if(eye_solved && heart_solved && brain_solved){
            GenCollectable.challangeSolved = true;
            puzzleDetector.GetComponent<BoxCollider2D>().enabled = false;
            Puzzle.SetActive(false);
        }
    }
    float RoundRotation(GameObject circle)
    {
        float Rotation;
        if (circle.transform.localRotation.eulerAngles.z <= 180f)
        {
            Rotation = circle.transform.localRotation.eulerAngles.z;
        }
        else
        {
            Rotation = circle.transform.localRotation.eulerAngles.z - 360f;
        }
        return Mathf.Round(Rotation);
    }

    void CheckCorrectedDegrees()
    {
        // eye
        if (targetDegreesEye == RoundRotation(eye))
        {
            eye_solved = true;
        }else if(targetDegreesEye != RoundRotation(eye)){
            eye_solved = false;
        }
        // heart
        if (targetDegreesHeart == RoundRotation(heart))
        {
            heart_solved = true;
        }else if(targetDegreesHeart != RoundRotation(heart)){
            heart_solved = false;
        }
        // brain
        if (targetDegreesBrain == RoundRotation(brain))
        {
            brain_solved = true;
        }else if(targetDegreesBrain != RoundRotation(brain)){
            brain_solved = false;
        }
        print("1 " + eye_solved);
        print("2 " + heart_solved);
        print("3 " + brain_solved);
        // print(Mathf.Round(Rotation));
    }
}
