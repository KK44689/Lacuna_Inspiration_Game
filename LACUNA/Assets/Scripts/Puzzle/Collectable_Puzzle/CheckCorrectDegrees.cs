using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectDegrees : MonoBehaviour
{
    // public GameObject checkCollider;
    GameObject circle1;
    GameObject circle2;
    public GameObject Puzzle;
    GameObject circle3;
    GameObject circle4;

    List<float> targetDegrees1 = new List<float> { -45f, -135f, 135f, 45f };
    List<float> targetDegrees2 = new List<float> { 0f};
    List<float> targetDegrees3 = new List<float> { -90f,90f};
    List<float> targetDegrees4 = new List<float> { 0f,180f};

    bool circle1_solved;

    bool circle2_solved;

    bool circle3_solved;

    bool circle4_solved;

    void Start()
    {
        circle1_solved = false;
        circle2_solved = false;
        circle3_solved = false;
        circle4_solved = false;
        circle1 = GameObject.Find("circle_1");
        circle2 = GameObject.Find("circle_2");
        circle3 = GameObject.Find("circle_3");
        circle4 = GameObject.Find("circle_4");
    }

    void Update()
    {
        CheckCorrectedDegrees();
        CheckAllCorrected();
    }

    void CheckAllCorrected(){
        if(circle1_solved && circle2_solved && circle3_solved && circle4_solved){
            PandoraController.challangeSolved = true;
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
        // circle_1
        if (targetDegrees1.Contains(RoundRotation(circle1)))
        {
            circle1_solved = true;
        }else if(!targetDegrees1.Contains(RoundRotation(circle1))){
            circle1_solved = false;
        }
        // circle_2
        if (targetDegrees2.Contains(RoundRotation(circle2)))
        {
            circle2_solved = true;
        }else if(!targetDegrees2.Contains(RoundRotation(circle2))){
            circle2_solved = false;
        }
        // circle_3
        if (targetDegrees3.Contains(RoundRotation(circle3)))
        {
            circle3_solved = true;
        }else if(!targetDegrees3.Contains(RoundRotation(circle3))){
            circle3_solved = false;
        }
        // circle_4
        if (targetDegrees4.Contains(RoundRotation(circle4)))
        {
            circle4_solved = true;
        }else if(!targetDegrees4.Contains(RoundRotation(circle4))){
            circle4_solved = false;
        }
        print("1 " + circle1_solved);
        print("2 " + circle2_solved);
        print("3 " + circle3_solved);
        print("4 " + circle4_solved);
        // print(Mathf.Round(Rotation));
    }
}
