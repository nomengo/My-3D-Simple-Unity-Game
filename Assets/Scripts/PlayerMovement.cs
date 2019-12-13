using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    Vector3 startPos;

    public int Basış;
    public int Gelen;


    public float speed;
    public  bool isOnGround;
    private Rigidbody rb;
    public bool Fail;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = this.transform.position;
        Gelen = 1;
    }
    

    
    void Update()
    {
       if(Fail == false)
        {
            
            if (isOnGround == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    
                    rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
                    isOnGround = false;
                    Gelen = Gelen + 2;

                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Basış = Basış + 1;
                transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0, 0, speed), Time.deltaTime * (Basış - Gelen) );
            }
            
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isOnGround = true;
        }
        if(collision.collider.tag == "Barrier")
        {
            Fail = true;
            Debug.Log("OYUN BİTTİ!!!");
        }
        if(collision.collider.tag == "Jumper")
        {
            rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
        }
    
        
    }
}
