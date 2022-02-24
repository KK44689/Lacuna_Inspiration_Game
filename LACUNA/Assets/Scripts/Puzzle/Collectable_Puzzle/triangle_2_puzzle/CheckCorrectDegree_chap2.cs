using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectDegree_chap2 : MonoBehaviour
{
    GameObject eye;

    GameObject heart;

    GameObject brain;

    public GameObject Puzzle;

    public GameObject puzzleDetector;

    List<float> targetDegreesEye = new List<float> { -45f };

    List<float> targetDegreesHeart = new List<float> { 45f };

    List<float> targetDegreesBrain = new List<float> { 180f, -180f };

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

    void CheckAllCorrected()
    {
        if (eye_solved && heart_solved && brain_solved)
        {
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
        print("brain " + RoundRotation(brain).ToString());

        // eye
        if (targetDegreesEye.Contains(RoundRotation(eye)))
        {
            eye_solved = true;
        }
        else if (!targetDegreesEye.Contains(RoundRotation(eye)))
        {
            eye_solved = false;
        }

        // heart
        if (targetDegreesHeart.Contains(RoundRotation(heart)))
        {
            heart_solved = true;
        }
        else if (!targetDegreesHeart.Contains(RoundRotation(heart)))
        {
            heart_solved = false;
        }

        // brain
        if (targetDegreesBrain.Contains(RoundRotation(brain)))
        {
            brain_solved = true;
        }
        else if (!targetDegreesBrain.Contains(RoundRotation(brain)))
        {
            brain_solved = false;
        }
    }
}
