using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 1.5f;
    private Vector3 initialPosition = new Vector3(-2, 3f, 0f);

    void Start()
    {
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //pegaposição do mouse
        mousePosition = Input.mousePosition;
        //converter a posicao do mousePosition para o sistema de cordenada da tela
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //alterar a posicao do object de acordo com a posicao do mouse
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
