using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdShipMove : MonoBehaviour
{
    bool wasHit;
    void OnCollisionEnter2D(Collision2D other)
    {            
        wasHit = true;
        CamFollow.player = other.gameObject.transform;
        if (other.gameObject.CompareTag("END"))
        {
            wasHit = false;
        }
    }
   
      void Update() 
    {
        if (wasHit)
        {
          GetComponent<Transform>().Translate(new Vector3(0.3f, 0, 0));
        }
    }
}
