using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    // Start is called before the first frame update
    bool wasHit;
    void OnCollisionEnter2D(Collision2D other)
    {
        wasHit = true;
        if (other.gameObject.CompareTag("SHIP"))
        {
            wasHit = false;
            CamFollow.player = other.gameObject.transform;
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