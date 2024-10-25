using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject door;
    public float numero = 5;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            door.transform.Translate(new Vector3(0, numero, 0));
            Destroy(this.gameObject);
        }
    }
}
