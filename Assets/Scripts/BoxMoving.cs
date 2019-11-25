using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoving : MonoBehaviour
{
    private Transform tf;

    public float Place;

    private float Direction;

    public int moveCheck;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the box back and forth continuously
        if (moveCheck == 1)
        {
            GetComponent<AudioSource>().volume = 1;
        }

        else
        {
            GetComponent<AudioSource>().volume = 0;
        }
        if (Place <= 0)
        {
            Direction = .01f;
        }

        if (Place >= 2f)
        {
            Direction = -.01f;
        }

        tf.position += new Vector3(Direction, 0f);
        Place += Direction;
        

    }

}
