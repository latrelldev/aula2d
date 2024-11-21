using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScreenDown : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;
  
    public void MoveDown()
    {
      _panel.transform.Translate(new Vector3(0,-1079, 0));
    }
}
