using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableText : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup UIGroup;

    float delay = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (UIGroup.alpha < 1)
        {
            UIGroup.alpha += Time.deltaTime;
            delay -= Time.deltaTime;
        }
        if (delay <= 0)
        {
            print("fade out");
            print(UIGroup.alpha);
            UIGroup.alpha -= 1.5f*Time.deltaTime;
        }
    }
}
