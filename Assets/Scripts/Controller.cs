using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Transform tf;

    public float speed;

    private float xMovement;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;

        tf.position += new Vector3(xMovement, 0f);

        if (xMovement > 0.01f)
        {
            GetComponent<Animator>().Play("PlayerWalk");
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (xMovement < -0.01f)
        {
            GetComponent<Animator>().Play("PlayerWalk");
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<Animator>().Play("PlayerIdle1");
        }
    }
}
