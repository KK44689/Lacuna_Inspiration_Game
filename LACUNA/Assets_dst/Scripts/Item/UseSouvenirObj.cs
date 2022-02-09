using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSouvenirObj : MonoBehaviour
{
    // public GameObject pickUpText;

    public GameObject SouvenirObj;

    GameObject pandora;

    bool souvenirAllowed = false;
    public static bool souvenirPicked = false;

    // Start is called before the first frame update
    void Start()
    {
        // pickUpText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //  && Input.GetKeyDown(KeyCode.E)
        if (souvenirAllowed)
        {
            // pickUpText.SetActive(false);
            pandora = GameObject.FindWithTag("Player");
            Transform pandoraTransform = pandora.transform;
            Vector2 pandoraPosition = pandoraTransform.position;

            // generate souvenir obj.
            GameObject SouvenirObject =
                Instantiate(SouvenirObj, pandoraPosition, Quaternion.identity);
            PositionPickedUpItem SouvenirObjectPos =
                SouvenirObject.GetComponent<PositionPickedUpItem>();
            souvenirPicked = true;
            // delete collider
            Destroy (gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            // pickUpText.SetActive(true);
            souvenirAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            // pickUpText.SetActive(false);
            souvenirAllowed = false;
        }
    }
}
