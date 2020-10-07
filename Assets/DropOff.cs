using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOff : MonoBehaviour
{
    
    public GameObject SignToShow;
    
    // Start is called before the first frame update
    void Start()
    {
        SignToShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SignToShow.SetActive(true);
    }
}
