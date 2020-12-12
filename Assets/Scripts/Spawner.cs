using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static float spawnRate = 0.5f;

    public GameObject HexagonPrefab1;
    public GameObject HexagonPrefab2;

    private int prefabNumber;

    private float nextTimeToSpawn = 0f;

    void Start()
    {
        //Instantiate(HexagonPrefab, Vector3.zero, Quaternion.identity);
    }

    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            prefabNumber = Random.Range(1, 3);
            if(prefabNumber == 1)
                Instantiate(HexagonPrefab1, Vector3.zero, Quaternion.identity);
            else if(prefabNumber == 2)
                Instantiate(HexagonPrefab2, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
