using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoadGenerator : MonoBehaviour
{
    public GameObject Road;
    public GameObject Player;
    private int Sayaç;
    

    
    void Start()
    {
        
        Sayaç = 1;
      
    }

    
    void Update()
    {
            if (Player.transform.position.z >= 40*Sayaç)
            {
            Sayaç = Sayaç + 1;
            Instantiate(Road, new Vector3(0, 0, 40 * Sayaç),Quaternion.identity);
            }
        
    }
    
}
