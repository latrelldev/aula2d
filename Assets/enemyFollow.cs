using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public Transform heroTransform;
    float velocidade = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pega a posicao relativa entre um obj e outro 
        Vector3 relativePos =  heroTransform.position;
        //calcula o angulo na rotacao do transform
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        //altera a posicao do inimigo de acordo com a posicao do heroi
        transform.position = Vector2.Lerp(transform.position, heroTransform.position, Time.deltaTime*velocidade);
    }
}
