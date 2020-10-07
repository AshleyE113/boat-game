using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FixtureToFall;
    public Rigidbody2D TheTrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        TheTrigger.mass = 0.1f;
        GetComponent<Transform>().Translate(new Vector3(0, -1, 0));
    }
}
