using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingPuzzle : MonoBehaviour
{
    [SerializeField]
    Transform topPivot;

    [SerializeField]
    Transform bottomPivot;
    [SerializeField]
    Transform topPivotHook;

    [SerializeField]
    Transform bottomPivotHook;

    [SerializeField]
    Transform fish;

    float fishPosition;

    float fishDestination;

    float fishTimer;

    [SerializeField]
    float timerMultiplicator = 3f;

    float fishSpeed;

    [SerializeField]
    float smoothMotion = 1f;

    [SerializeField]
    Transform hook;

    float hookPosition;

    [SerializeField]
    float hookSize = 0.1f;

    [SerializeField]
    float hookPower = 0.5f;

    float hookProgress;

    float hookPullVelocity;

    [SerializeField]
    float hookPullPower = 0.01f;

    [SerializeField]
    float hookGravityPower = 0.005f;

    [SerializeField]
    float hookProgressDegradationPower = 0.1f;

    [SerializeField]
    Image hookImage;

    [SerializeField]
    Transform progressBarContainer;

    // [SerializeField]
    // Transform HookAreaContainer;

    bool pause = false;

    [SerializeField]
    float failTimer = 10f;

    [SerializeField]
    GameObject fishRod;

    public static bool fishingComplete = false;

    public static int score = 0;

    void OnEnable()
    {
        ResizeHookArea();
        hookProgress = 0;
        fishRod.SetActive(false);
        failTimer = 10f;
        pause = false;
    }

    private void ResizeHookArea()
    {
        // Bounds b = hookImage.bounds;
        float ySize = hookImage.rectTransform.rect.height;
        Vector3 ls = hook.localScale;
        hookSize = Random.Range(0.08f, 0.25f);
        float distance =
            Vector3.Distance(topPivot.position, bottomPivot.position);
        ls.y = (distance / ySize * hookSize);
        hook.localScale = ls;
    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
        {
            return;
        }
        Fish();
        Hook();
        ProgressCheck();
    }

    private void ProgressCheck()
    {
        Vector3 ls = progressBarContainer.localScale;
        ls.y = hookProgress;
        progressBarContainer.localScale = ls;
        float min = hookPosition - hookSize / 2;
        float max = hookPosition + hookSize / 2;

        if (min < fishPosition && fishPosition < max)
        {
            hookProgress += hookPower * Time.deltaTime;
            // failTimer = 5f;
        }
        else
        {
            hookProgress -= hookProgressDegradationPower * Time.deltaTime;
            failTimer -= Time.deltaTime;
            if (failTimer < 0f && hookProgress <= 0f)
            {
                Lost();
            }
        }
        if (hookProgress >= 1f)
        {
            Win();
        }

        hookProgress = Mathf.Clamp(hookProgress, 0f, 1f);
    }

    void Lost()
    {
        pause = true;
        fishRod.SetActive(true);
        gameObject.SetActive(false);
        DelayBeforeFishing.delay = Random.Range(1f, 5f);
        print("lose");
    }

    void Win()
    {
        pause = true;
        score++;
        DelayBeforeFishing.delay = Random.Range(1f, 5f);
        fishRod.SetActive(true);
        gameObject.SetActive(false);
        print("fish caughted");
    }

    void Hook()
    {
        float ySize = hookImage.rectTransform.rect.height;
        print("bottom "+bottomPivotHook.position.y.ToString());
        print("top "+topPivotHook.position.y.ToString());
        if (Input.GetMouseButton(0))
        {
            hookPullVelocity += hookPullPower * Time.deltaTime;
        }
        hookPullVelocity -= hookGravityPower * Time.deltaTime;
        hookPosition += hookPullVelocity;
        
        if (bottomPivotHook.position.y <= bottomPivot.position.y && hookPullVelocity < 0f)
        {
            hookPullVelocity = 0f;
        }
        // if (hookPosition - hookSize / 2 <= 0f && hookPullVelocity < 0f)
        // {
        //     hookPullVelocity = 0f;
        // }
        if (topPivotHook.position.y >= topPivot.position.y && hookPullVelocity > 0f)
        {
            hookPullVelocity = 0f;
        }

        hookPosition =
            Mathf.Clamp(hookPosition, hookSize / 2, 1 - hookSize / 2);

        // print (hookPosition);
        hook.position = Vector3.Lerp(bottomPivot.position, topPivot.position, hookPosition);
    }

    void Fish()
    {
        fishTimer -= Time.deltaTime;
        if (fishTimer < 0f)
        {
            fishTimer = UnityEngine.Random.value * timerMultiplicator;

            fishDestination = UnityEngine.Random.value;
        }

        fishPosition =
            Mathf
                .SmoothDamp(fishPosition,
                fishDestination,
                ref fishSpeed,
                smoothMotion);

        fish.position =
            Vector3.Lerp(bottomPivot.position, topPivot.position, fishPosition);
    }
}
