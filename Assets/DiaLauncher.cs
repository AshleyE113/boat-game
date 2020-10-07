using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaLauncher : MonoBehaviour
{
public GameObject DiamondLauncher;

     void Start() 
    { 
    }
private void OnTriggerEnter2D(Collider2D other)
    {
       GetComponent<Transform>().Translate(new Vector3(0, 1.5f, 0));
    }
}
