using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    

    
    void Update()
    {
        this.gameObject.transform.Rotate(45*Time.deltaTime, 45 * Time.deltaTime, 45 * Time.deltaTime);
    }
}
