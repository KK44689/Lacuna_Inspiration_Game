using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandoraController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    float horizontal;

    public float speed = 10.0f;

    int lookDirecTemp = 1;

    // public static bool challangeSolved;

    // bool destroyCollectable = false;

    // public GameObject collectable;
    GameObject npc;


    // public GameObject gameOver;
    // public Transform checkPoint;
    public GameObject bouquet;

    // public static bool flowerAllCollected = false;
    // public static bool ReturnCheckPoint = false;
    AudioSource audioSource;

    Animator animator;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();
        // challangeSolved = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if (ReturnCheckPoint)
        // {
        //     transform.position = checkPoint.position;
        //     EnemyController.gameover = false;
        //     ReturnCheckPoint = false;
        //     gameOver.SetActive(false);
        // }
    }

    void FixedUpdate()
    {
        npc = GameObject.FindWithTag("NPC");
        // generateBouquet();
        if(CharStopMove.charStop){
            animator.SetBool("walk", false);
            return;
        }
        if (DialogueManager.isActive == true)
        {
            if (transform.position.x >= npc.transform.position.x)
            {
                lookDirection(1);
                lookDirecTemp = 1;
            }
            else if (transform.position.x < npc.transform.position.x)
            {
                lookDirection(-1);
                lookDirecTemp = -1;
            }
            animator.SetBool("walk", false);
            return;
        }
        if (FlowerTutorial.flowerTutorial_stop)
        {
            lookDirection(-1);
            animator.SetBool("walk", false);
            return;
        }
        PlayerWalk();
        // generateCollectable();
        PlayCollectitemSound();
    }

    void PlayCollectitemSound()
    {
        if (InspireItem.PlayPickupSound)
        {
            // print("test");
            SoundManager.PlaySoundItem("receiveItem");
            InspireItem.PlayPickupSound = false;
        }
    }

    // **************** Player Movement ************************** \\
    void PlayerWalk()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            lookDirection(-1);
            lookDirecTemp = -1;
            animator.SetBool("walk", true);
            // Debug.Log("right");
        }
        else if (horizontal < 0)
        {
            lookDirection(1);
            lookDirecTemp = 1;
            animator.SetBool("walk", true);
            // Debug.Log("left");
        }
        else
        {
            lookDirection (lookDirecTemp);
            animator.SetBool("walk", false);
            // Debug.Log("idle");
        }
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;

        rigidbody2d.MovePosition (position);
    }

    void lookDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;
        tempScale.x = direction;
        transform.localScale = tempScale;
    }

    // void generateCollectable()
    // {
    //     if (challangeSolved && destroyCollectable == false)
    //     {
    //         print("show collectable");
    //         Vector2 tempPos = transform.position;
    //         tempPos.y = transform.position.y + 3f;

    //         GameObject CollectableObject =
    //             (GameObject)
    //             Instantiate(collectable, tempPos, Quaternion.identity);
    //         PositionPickedUpItem CollectableObjectPos =
    //             CollectableObject.GetComponent<PositionPickedUpItem>();
    //         Destroy(CollectableObject, 0.5f);
    //         destroyCollectable = true;
    //     }
    // }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot (clip);
    }
}
