using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    public GameObject objectToSpawn;
    public int numberOfObjects = 5;
    private GameObject[] spawnedObjects;

    void Start()
    {
        spawnedObjects = new GameObject[numberOfObjects];

        for (int i = 0 i < numberOfObjects; i++);
        {
            GameObject obj = Instantiate(objectToSpawn, new Vector3(i * 2, 0, 0), Quaternion.identity);
            spawnedObjects[i] = obj; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject)
    }
}
