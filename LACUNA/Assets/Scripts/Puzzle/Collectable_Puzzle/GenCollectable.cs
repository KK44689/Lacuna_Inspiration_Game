using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenCollectable : MonoBehaviour
{
    public GameObject collectable;
    // float delay = 0.3f;


    public static bool challangeSolved = false;

    bool destroyCollectable = false;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(CollectableObject,3f);
            // Destroy(CollectableObject, 0.5f);
            destroyCollectable = true;
        }
    }
}
