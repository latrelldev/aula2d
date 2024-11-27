using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerShoot : MonoBehaviour
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

    public void ShootFast (ScoreController scoreController)
    {
        if (scoreController.Score == 10)
        {
            _timeshot = 0.27f;
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
   
}
