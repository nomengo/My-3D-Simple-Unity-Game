using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    Vector3 startPos;
    public int speed;
    public  bool isOnGround;
    private Rigidbody rb;
    private bool Fail;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = this.transform.position;
    }
    

    // Update is called once per frame
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
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
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
