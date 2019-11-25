using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    public int start = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the game starts...
        if (start == 1)
        {
            //PLay the music
            GetComponent<AudioSource>().Play();
        }
    }
}
