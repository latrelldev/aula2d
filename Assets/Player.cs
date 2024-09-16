using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        transform.Translate(direction * speed * Time.deltaTime, 0f, 0f);
    }
}
