using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFishCaught : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = FishingPuzzle.score.ToString();
    }
}
