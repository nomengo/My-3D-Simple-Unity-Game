using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfiniteRoadGenerator : MonoBehaviour
{
    public GameObject Road1;
    public GameObject Road2;
    public GameObject Player;
    private int Sayaç;
    private int Hak;

    private GameObject instanceCache;

    
    
    
    void Start()
    {
        Sayaç = 1;
        Hak = 1;
        
    }

    
    void Update()
    {

        if (FindObjectOfType<CameraController>().Player != null)
        {
            if (Player.transform.position.z >= 40 * Sayaç)
            {
                Sayaç = Sayaç + 1;
                Destroy(instanceCache, 3);
                instanceCache = Instantiate(Road1, new Vector3(0, 0, 40 * Sayaç), Quaternion.identity);
            }
            if (Player.transform.position.z >= 60 * Hak)
            {
                Hak = Hak + 1;
                Destroy(instanceCache, 3);
                instanceCache = Instantiate(Road2, new Vector3(0, 0, 65 * Hak), Quaternion.identity);
            }
        }
        
        
        
    }
    
    
}
