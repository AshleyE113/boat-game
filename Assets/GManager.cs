﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

      public bool getStarted = false;
      public static GManager Singleton;

      private void Awake() 
      {
        Singleton = this;  
      }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
          getStarted = true;
          
        }
    }
}
