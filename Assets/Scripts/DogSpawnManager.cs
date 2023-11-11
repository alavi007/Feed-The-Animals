using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float startDelay = 6;
    private float spawnInterval = 7;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomVariable", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomVariable()
    {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(-25, 0, -6), animalPrefabs[animalIndex].transform.rotation);
    }
}
