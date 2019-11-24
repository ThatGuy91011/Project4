using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public string scoreText = "Current Score: ";
    public Text scoreContainer;
    public int currentScore = 0;

    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
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
            
            //Add 1 to score variable
            currentScore++;
            //Update score
            scoreContainer.text = scoreText + currentScore;
            //Play sound
            //Destroy object
            GetComponent<Collider>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            GetComponent<Transform>().position = Vector3.zero;

            //GameObject.Find("SoundManager").GetComponent<AudioSource>().PlayClipAtPoint(clip, new Vector3(5, 6));
        }

    }
}
