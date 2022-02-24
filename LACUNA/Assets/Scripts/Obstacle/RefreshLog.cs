using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshLog : MonoBehaviour
{
    public Button RefreshButton;

    public GameObject LogRolled;

    public GameObject Log;

    // Start is called before the first frame update
    void Start()
    {
        RefreshButton.onClick.AddListener (TaskOnClick);
    }

    void TaskOnClick()
    {
        LogRolled.transform.position = LogRoll.startPos;
        LogRolled.transform.localRotation = Quaternion.identity;
        LogCollider.hideLog = false;
        LogRoll.stopRolling = false;
        LogRoll.hitFloor = false;
        Log.SetActive(true);
    }
}
