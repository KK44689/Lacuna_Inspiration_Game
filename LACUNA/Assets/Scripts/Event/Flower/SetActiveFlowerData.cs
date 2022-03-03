using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveFlowerData : MonoBehaviour
{
    [SerializeField]
    private ItemData ItemData;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemData.allFlowerCollected){
            gameObject.SetActive(false);
        }
    }
}
