using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamFollow : MonoBehaviour
{
     public Transform ball;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ball.position.x, ball.position.y, transform.position.z);
    }
}
