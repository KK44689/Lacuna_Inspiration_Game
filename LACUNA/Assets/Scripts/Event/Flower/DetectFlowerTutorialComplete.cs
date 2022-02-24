using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFlowerTutorialComplete : MonoBehaviour
{
    public GameObject nextCollider;

    // Start is called before the first frame update
    void Start()
    {
        nextCollider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // active collider when flower tutorial complete
        if (FlowerTutorial.flowerCorrect_Collected)
        {
            nextCollider.SetActive(true);
        }
    }
}
