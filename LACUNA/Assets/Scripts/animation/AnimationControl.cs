using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
            animator.SetBool("walk", true);
        }
        else if(Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("walk", false);
        }
    }
}
