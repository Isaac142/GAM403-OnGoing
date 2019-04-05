using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int rndX = Random.Range(-15, 15);
        int rndZ = Random.Range(-15, 15);

        Vector3 spawnPos = new Vector3(rndX, 0, rndZ);
        Instantiate(spawnObject, spawnPos, transform.rotation);
    }
}
