using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCollectableBehaviour : MonoBehaviour, ICollectableBehaviour
{
    public bool _isCollected;

    public void OnCollected(GameObject player)
    {
        _isCollected = true;
        Debug.Log("dawdwad");
    }
}
