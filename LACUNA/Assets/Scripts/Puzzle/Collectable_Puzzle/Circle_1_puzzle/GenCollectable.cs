using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenCollectable : MonoBehaviour
{
    public GameObject collectable;

    public static bool challangeSolved = false;

    bool destroyCollectable = false;

    Animator animator;

    // load/save puzzle variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        challangeSolved = PuzzleData.puzzle_circle1_solved;
    }

    // Update is called once per frame
    void Update()
    {
        generateCollectable();
    }

    void generateCollectable()
    {
        if (challangeSolved && destroyCollectable == false)
        {
            print("show collectable");
            Vector2 tempPos = transform.position;
            tempPos.y = transform.position.y + 3f;
            GameObject CollectableObject =
                (GameObject)
                Instantiate(collectable, tempPos, Quaternion.identity);
            CollectableObject.transform.parent = transform;
            animator = CollectableObject.GetComponent<Animator>();
            animator.SetBool("challenge_solve", true);
            Destroy(CollectableObject, 3f);
            destroyCollectable = true;
            PuzzleData.puzzle_circle1_solved = challangeSolved;
        }
        Debug
            .Log("puzzle_circle1_solved_load/save--" +
            PuzzleData.puzzle_circle1_solved);
        Debug.Log("puzzle_circle1_solved--" + challangeSolved);
    }
}
