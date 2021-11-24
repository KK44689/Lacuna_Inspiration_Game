using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenInspirePiece : MonoBehaviour
{
    // bool useInspirePiece = false;
    GameObject pandora;

    public GameObject inspire_piece;

    float timer = 3f;

    bool genInspirePiece = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (UseSouvenirObj.souvenirPicked)
        {
            if (timer > 0)
            {
                timer -= 1f * Time.deltaTime;
                // print (timer);
            }
            else if (Mathf.Round(timer) == 0)
            {
                if (genInspirePiece)
                {
                    generateInspirePiece();
                    genInspirePiece = false;
                }
                else
                {
                    return;
                }

                // Destroy(gameObject);
            }
        }
    }

    void generateInspirePiece()
    {
        pandora = GameObject.FindWithTag("Player");
        Transform pandoraTransform = pandora.transform;
        Vector2 pandoraPosition = pandoraTransform.position;
        Vector2 tempPos = transform.position;
        tempPos.y = transform.position.y + 1f;

        // generate inspire piece
        GameObject Inspire_Piece =
            Instantiate(inspire_piece, tempPos, Quaternion.identity);
        PositionInspirePiece InspirePiecePos =
            Inspire_Piece.GetComponent<PositionInspirePiece>();
    }
}
