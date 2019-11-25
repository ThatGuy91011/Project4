using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public AudioClip clip;

    public GameObject scoreHolder;
    // Start is called before the first frame update
    void Start()
    {
        scoreHolder = GameObject.FindWithTag("Score");
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Detect collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            //Add 1 to score variable in Score
            scoreHolder.GetComponent<Score>().currentScore++;

            //Destroy object
            GetComponent<CapsuleCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            GetComponent<Transform>().position = Vector3.zero;
        }

    }
}
