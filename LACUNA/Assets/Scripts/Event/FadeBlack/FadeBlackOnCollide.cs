using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlackOnCollide : MonoBehaviour
{
    public GameObject fadeBlack;

    [SerializeField]
    string charType;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals(charType))
        {
            fadeBlack.SetActive(true);
        }
    }
}
