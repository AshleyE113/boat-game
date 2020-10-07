using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMeUp : MonoBehaviour
{
    public GameObject passenger;
    public static bool pickedUp;
    public bool CharPickedUp;
    // Start is called before the first frame update
    void Start()
    {
        pickedUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (DestroyButton.wasDestroyed)
        //{
            Debug.Log("Button's Gone!");
            if (CharPickedUp && Input.GetKey(KeyCode.Space))
            {
                pickedUp = true;
                Destroy(passenger);
                Debug.Log("Picked!");
            }

        //}
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Entered the CHar's box!");
        if (other.gameObject.tag.Equals("SHIP"))
        {
            Debug.Log("In the if!");
            CharPickedUp = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.tag.Equals("SHIP"))
        {
            CharPickedUp = false;
        }
    }
}
