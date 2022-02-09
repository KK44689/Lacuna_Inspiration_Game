using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlackTrigger : MonoBehaviour
{
    public GameObject fadeBlack;
    // Start is called before the first frame update
    void Start()
    {
        fadeBlack.SetActive(true);
    }

}
