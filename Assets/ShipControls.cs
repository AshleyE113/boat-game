using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{

//Start as false
    public bool finished;
    public bool GoRight;
    public bool GoLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !GoLeft)
        {
            GetComponent<Transform>().Translate(new Vector3(0.5f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && !GoRight)
        {
            GetComponent<Transform>().Translate(new Vector3(-0.5f, 0, 0));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        
       if (other.CompareTag("LEFT END"))
       {
           GoRight = true;
       }
       else
       {
            GoRight = false;
       }
       
       if (other.CompareTag("END"))
       {
           GoLeft = true;
       }
       else
       {
           GoLeft = false;
       }

    }
}
