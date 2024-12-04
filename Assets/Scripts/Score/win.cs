using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    [SerializeField]
    private GameObject _winScreen;

    public void Ganhou()
    {
        _winScreen.SetActive(true);
    }
}
