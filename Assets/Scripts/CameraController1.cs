﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController1 : MonoBehaviour
{
    public GameObject Player;
    public Text Score;
    public float Mesafe;
    public Text Para;
    public GameObject GameOverScreen;

    private Vector3 offset;


    void Start()
    {
        offset = transform.position - Player.transform.position;
    }
    private void Update()
    {
        if (Player != null)
        {
            Mesafe = Player.transform.position.z;
            Para.text = FindObjectOfType<PlayerMovement>().Money.ToString();
            if (Player.transform.position.y <= -5)
            {
                Destroy(Player);
                Debug.Log("OYUN BİTTİ");
            }
        }
        else
        {
            Score.text = "Traveled Distance : " + Mesafe.ToString();
        }
    }


    void LateUpdate()
    {
        if (Player != null)
        {
            transform.position = Player.transform.position + offset;
        }
        else
        {
            GameOverScreen.SetActive(true);
        }
    }

}



