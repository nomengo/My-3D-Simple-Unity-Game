using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float startDistance = 20;
    public float zDistance = 50;
    public float minSpread = 15;
    public float maxSpread = 50;

    public Transform playerTransform;
    public Transform obstaclePrefab;

    float zSpread;
    float lastzPos;

    
    void Start()
    {
        zSpread = Random.Range(minSpread, maxSpread);
        lastzPos = playerTransform.position.z + (startDistance - zSpread - zDistance);
    }

    
    void Update()
    {
        if(playerTransform.position.z - lastzPos >= zSpread)
        {
            float lanePos = Random.Range(1, 2);
            lanePos = lanePos - 1;
            Instantiate(obstaclePrefab, new Vector3(lanePos, 0.5f, lastzPos + zSpread + zDistance), Quaternion.identity);

            lastzPos += zSpread;
            zSpread = Random.Range(minSpread, maxSpread);
        }
    }
}
