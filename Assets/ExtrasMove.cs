using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasMove : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Translate(new Vector3(0.3f, 0, 0));
    }
}
