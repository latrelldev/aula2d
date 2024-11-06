using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
   private HealthController _healthController;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
    }

    public void StartInvincibility(float invincibilityDuration)
    {
        StartCoroutine(InvincibiltyCoroutine(invincibilityDuration));
    }

    private IEnumerator InvincibiltyCoroutine (float invincibilityDuration)
    {
        _healthController.IsInvencible = true;
        yield return new WaitForSeconds (invincibilityDuration);
        _healthController.IsInvencible = false;
    }
}
