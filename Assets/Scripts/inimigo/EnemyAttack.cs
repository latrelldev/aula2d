using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private float _damageAmount;

    private void OnCollisionStay2D(Collision2D collission)
    {
        if (collission.gameObject.GetComponent<PlayerMovement>())
        {
            var healthController = collission.gameObject.GetComponent<HealthController>();
            healthController.TakeDamage(_damageAmount);
        }
    }

}
