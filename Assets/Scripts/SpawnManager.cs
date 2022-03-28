using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject roadPrefabs;
    private float zSpawn = 0;
    private float roadLength = 10f;
    private int numberOfRoads = 7;
    public Transform playerTransform;
    private List<GameObject> activeRoad = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < numberOfRoads; i++)
        {
            SpawnRoad();
        }
    }


    void Update()
    {
        if (playerTransform.position.z-25f > zSpawn - (numberOfRoads * roadLength))
        {
            SpawnRoad();
            DeleteRoad();
        }
    }

    public void SpawnRoad()
    {
        GameObject road = Instantiate(roadPrefabs, zSpawn * transform.forward, transform.rotation);
        activeRoad.Add(road);
        zSpawn += roadLength;
    }

    private void DeleteRoad()
    {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }


}
