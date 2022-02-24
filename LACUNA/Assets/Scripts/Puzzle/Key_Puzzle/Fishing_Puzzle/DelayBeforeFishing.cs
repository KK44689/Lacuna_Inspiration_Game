using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayBeforeFishing : MonoBehaviour
{
    public static float delay;

    public GameObject fishingPuzzle;

    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(1f, 5f);
        fishingPuzzle.SetActive(false);
        score.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!fishingPuzzle.active)
        {
            delay -= Time.deltaTime;
        }
        if (delay <= 0)
        {
            fishingPuzzle.SetActive(true);
        }
        if (gameObject.active)
        {
            score.SetActive(true);
        }
    }
}
