using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject Barrier;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyButton.wasDestroyed && PickMeUp.pickedUp)
        {
            Debug.Log("Barrier's gone!");
            Destroy(Barrier);
        }
    }
}
