using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn;

    public float minsSpawnTime = 0.5f;
    public float maxSpawnTime = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        timeToNextSpawn = Random.Range(minsSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        // Check if it's time to spawn a new object
        if (timeSinceLastSpawn >= timeToNextSpawn)
        {
            int selection = Random.Range(0, ObjectsToSpawn.Length);
            Instantiate(ObjectsToSpawn[selection], transform.position, Quaternion.identity);

            // Reset the spawn timer
            timeToNextSpawn = Random.Range(minsSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0;
        }
    }
}