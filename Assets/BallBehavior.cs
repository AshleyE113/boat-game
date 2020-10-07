using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public Rigidbody2D BallRB;
    //public Transform BallRot;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (GManager.Singleton.getStarted)
        {
            BallRB.simulated = true;
            
        }
    }
}
