using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ObstacleData : ScriptableObject
{
    public bool HidelogCollider = false;
    public bool logRollStop = false;
    public bool logRollHitFloor = false;
    public bool logRollHitEnemy = false;
    public bool blankLogActive = false;
}
