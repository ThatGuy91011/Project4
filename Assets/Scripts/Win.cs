using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("Finish").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //If the player wins the level...
        if (other.CompareTag("Player"))
        {
            //Show the Win canvas screen
            text.text = "You Win!";
            GameObject.Find("NextLevel").GetComponent<RectTransform>().localScale = new Vector3(.5f, .5f, 0);
        }
    }
}
