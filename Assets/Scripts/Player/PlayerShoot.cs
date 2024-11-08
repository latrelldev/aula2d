using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private GameObject _freezeGranadePrefab;

    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private Transform _gun;

    [SerializeField]
    private float _timeshot;

    private bool _fireContinuosly;
    private float _lastFireTime;
    private FreezeCollectableBehaviour _freezeCollectableBehaviour;

    // Update is called once per frame
    void Update()
    {
        if (_fireContinuosly)
        {
            float timeSinceLastFire = Time.time - _lastFireTime;

            if(timeSinceLastFire >= _timeshot)
            {
                FireBullet();
                _lastFireTime = Time.time;
            }
        }

    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(_bulletPrefab, _gun.position, _gun.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = _bulletSpeed * transform.up;
    }
    private void OnFire (InputValue inputValue)
    {
        _fireContinuosly = inputValue.isPressed;
    }

    private void FireFreezeGranade()
    {
        bool isCollectable = _freezeCollectableBehaviour._isCollected;

        if (isCollectable == true && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject freezeGranade = Instantiate(_freezeGranadePrefab, _gun.position, _gun.rotation);
            Rigidbody2D rigidbody = freezeGranade.GetComponent<Rigidbody2D>();

            rigidbody.velocity = _bulletSpeed * transform.up;
        }
        else
        {
            return;
        }

    }
   
}
