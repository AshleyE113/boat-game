using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyButton : MonoBehaviour
{
    public GameObject button;
    public static bool wasDestroyed;

    void Start()
    {
        wasDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Object.Destroy(button);
            wasDestroyed = true;
        }        
    }
}
