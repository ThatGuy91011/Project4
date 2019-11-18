using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoving : MonoBehaviour
{
    private Transform tf;

    private float Place;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Place == 0f)
        {
            tf.position += new Vector3(.01f, 0f);
            //Place += .01f;
        }

       /** else if (Place == 5f)
        {
            tf.position -= new Vector3(.01f, 0f);
            Place -= .01f;
        }**/
        
    }

}
