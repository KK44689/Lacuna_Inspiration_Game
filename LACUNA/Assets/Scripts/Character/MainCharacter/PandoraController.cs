using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandoraController : MonoBehaviour
{
    // Player movement variables
    private float horizontal;

    [SerializeField]
    private float speed = 10.0f;

    private int lookDirecTemp = 1;

    // gameobject variables
    Rigidbody2D rigidbody2d;

    private GameObject npc;

    // Sound variables
    AudioSource audioSource;
    public AudioClip pickItemSound;

    // Animation variables
    Animator animator;

    // load/save player variables
    [SerializeField]
    private PlayerData PlayerData;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();

        // make player position equals data
        Vector3 temp = transform.position;
        temp.x = PlayerData.position_player_x;
        transform.position = temp;
    }

    void Update()
    {
        // save data
        PlayerData.position_player_x = transform.position.x;
        // Debug.Log(PlayerData.position_player_x);
    }

    void FixedUpdate()
    {
        npc = GameObject.FindWithTag("NPC");

        // stop pandora when collide to collider
        if (CharStopMove.charStop)
        {
            animator.SetBool("walk", false);
            return;
        }

        // pandora stop moving when dialogue box active
        if (DialogueManager.isActive == true)
        {
            if (transform.position.x >= npc?.transform.position.x)
            {
                lookDirection(1);
                lookDirecTemp = 1;
            }
            else if (transform.position.x < npc?.transform.position.x)
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

        // pandora control walking
        PlayerWalk();

        // play collect item sound
        PlayCollectitemSound();
    }

    void PlayCollectitemSound()
    {
        // if pandora collect inspire item play sound
        if (InspireItem.PlayPickupSound)
        {
            // SoundManager.PlaySoundItem("receiveItem");
            PlaySound(pickItemSound);
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
        }
        else if (horizontal < 0)
        {
            lookDirection(1);
            lookDirecTemp = 1;
            animator.SetBool("walk", true);
        }
        else
        {
            lookDirection (lookDirecTemp);
            animator.SetBool("walk", false);
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

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot (clip);
    }
}
