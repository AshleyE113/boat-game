using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHim : MonoBehaviour
{
    public GameObject Fixture;
    //public Rigidbody2D Char;
    // Update is called once per frame

    bool canMove;

    void Start()
    {
        //Char = GetComponent<Rigidbody2D>();
    }

     void Update() 
    {
        GetComponent<Animator>().Play("Idle");
        if (canMove == true)
        {
            GetComponent<Animator>().Play("Right");
            GetComponent<Transform>().Translate(new Vector3(0.1f, 0, 0));
            Debug.Log("I'm RUnning!");
        }
    }
    void OnCollisionEnter2D(Collision2D Fixture)
    {
        Debug.Log("Hit!");
        canMove = true;
        if (Fixture.gameObject.CompareTag("SHIP"))
        {
            Debug.Log("I'm right here!");
            canMove = false;
            CamFollow.player = Fixture.gameObject.transform;
        }
    }
    
}
