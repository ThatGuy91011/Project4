using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Transform tf;

    public float speed;

    private float xMovement;

    public float yMovement;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
        yMovement = Input.GetAxis("Vertical");

        if (yMovement >= .4)
        {
            yMovement = 0;
        }

        tf.position += new Vector3(xMovement, yMovement);

        if (xMovement > 0.01f)
        {
            GetComponent<Animator>().Play("PlayerWalk");
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (xMovement < -0.01f)
        {
            GetComponent<Animator>().Play("PlayerWalk");
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<Animator>().Play("PlayerIdle1");
            GetComponent<AudioSource>().Stop();
        }

        if (yMovement > 0.01f)
        {
            GetComponent<Animator>().Play("PlayerJump");
        }
    }
}
