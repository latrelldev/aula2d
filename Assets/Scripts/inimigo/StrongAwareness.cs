using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongAwareness : MonoBehaviour
{
    [SerializeField]
    private float _playerAwarenessDistance;

    public bool AwareOfPlayer { get;  set; }
    public Vector2 DirectionToPlayer { get; private set; }
    private Transform _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }

        else
        {
            AwareOfPlayer = false;
        }
    }
}
