using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNextAfterDisable : MonoBehaviour
{
    public GameObject NextCollider;
    private void Start() {
        NextCollider.SetActive(false);
    }
    private void OnDisable() {
        NextCollider.SetActive(true);
    }
}
