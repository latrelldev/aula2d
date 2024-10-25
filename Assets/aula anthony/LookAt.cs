using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform heroi;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 relativePosition = heroi.position - transform.position;

        float angle = Mathf.Atan2(relativePosition.y, relativePosition.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
