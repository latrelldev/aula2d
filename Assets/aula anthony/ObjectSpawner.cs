using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;

    void Start()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

        Instantiate(objectToSpawn, new Vector3(-1.5f, 2.0f, 0f),Quaternion.identity); //Quaternion.identity pode ser usado como rotacao


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
