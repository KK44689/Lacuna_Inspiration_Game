using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIsActive : MonoBehaviour
{
    public GameObject monster;

    // load/save variables
    [SerializeField]
    private MonsterData MonsterData;

    // Update is called once per frame
    void Update()
    {
        MonsterData.monsterActive = monster.activeInHierarchy;
    }
}
