using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverFade : MonoBehaviour
{
    // public static Animator animator;
    public Image blackFade;

    float delay = 2f;

    float delayFadeIn = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // animator = gameObject.GetComponent<Animator>();
        blackFade.canvasRenderer.SetAlpha(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyController.gameover)
        {
            // animator.SetBool("Fade_In", true);
            fadeIn();
            if (delayFadeIn > 0)
            {
                delayFadeIn -= Time.deltaTime;
            }
            else
            {
                if (delay > 0)
                {
                    delay -= Time.deltaTime;
                }
                else
                {
                    ReturnToCheckPoint.ReturnCheckPoint = true;
                    fadeOut();
                    delay = 2f;
                    // gameObject.SetActive(false);
                }
            }
        }
    }

    void fadeIn()
    {
        blackFade.CrossFadeAlpha(1, 2f, false);
    }

    void fadeOut()
    {
        blackFade.CrossFadeAlpha(0, 2f, false);
    }
}
