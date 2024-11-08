using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FreezeGranade : MonoBehaviour
{
    [SerializeField]
    private float _enemyAwarenessDistance;

    public bool AwareOfEnemy { get; private set; }
    public Vector2 DirectionToEnemy { get; private set; }
    private Transform _enemy;

    private Camera _camera;

    public UnityEvent OnFreeze;

    private void Awake()
    {
        _camera = Camera.main;
        _enemy= FindObjectOfType<EnemyMovement>().transform;
    }

    private void Update()
    {
        DestroyWhenOffScreen();
        EnemyAwareness();
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthController = collision.GetComponent<HealthController>();
            healthController.TakeDamage(10);
            Destroy(gameObject);
        }
    }

    private void DestroyWhenOffScreen()
    {
        Vector2 screenPosition = _camera.WorldToScreenPoint(transform.position);

        if (screenPosition.x < 0 || screenPosition.x > _camera.pixelWidth ||
          screenPosition.y < 0 || screenPosition.y > _camera.pixelHeight)
        {
            Destroy(gameObject);
        }
    }

    public void EnemyAwareness()
    {
            Vector2 granadeToPlayerVector = _enemy.position - transform.position;
            DirectionToEnemy = granadeToPlayerVector.normalized;

            if (granadeToPlayerVector.magnitude <= _enemyAwarenessDistance)
            {
                AwareOfEnemy = true;
                OnFreeze.Invoke();
            }

            else
            {
                AwareOfEnemy = false;
            }
        
    }
    
}
