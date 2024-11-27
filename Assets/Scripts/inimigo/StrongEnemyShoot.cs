using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

public class StrongEnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;


    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private Transform _gun;

    [SerializeField]
    private float _timeshot;

    private bool _fireContinuosly;
    private float _lastFireTime;

    private StrongAwareness _playerAwarenessController;
    private Transform _player;

    private void Awake()
    {
        _playerAwarenessController = GetComponent<StrongAwareness>();
        _player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        if (_playerAwarenessController.AwareOfPlayer == true)
        {
            float timeSinceLastFire = Time.time - _lastFireTime;

            if (timeSinceLastFire >= _timeshot)
            {
                FireBullet();
                _lastFireTime = Time.time;

            }
        }

    }


    private void FireBullet()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        GameObject bullet = Instantiate(_bulletPrefab, _gun.position, _gun.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = _bulletSpeed * enemyToPlayerVector;
    }
    private void OnFire(InputValue inputValue)
    {
        _fireContinuosly = _playerAwarenessController.AwareOfPlayer = true;
        Debug.Log("123123132");
    }
}
