using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        //If the player touches the flag...
        if (other.CompareTag("Player"))
        {
            //Change the CP variable in Controller so that the player knows to respawn at the checkpoint
            GameObject.Find("Player").GetComponent<Controller>().CP = 1;
        }
    }
}
