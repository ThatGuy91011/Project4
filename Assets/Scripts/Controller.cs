using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Transform tf;

    public float speed;

    private float xMovement;

    public int moveCheck = 0;

    public bool isGrounded = false;

    private Scene scene;

    public int CP;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();

        //Automatically lets the player move if it is the second level
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            moveCheck = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //If the game has started...
        if (moveCheck == 1)
        {
            //If it is Level 2...
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                //If the player falls within the death zone...
                if (tf.position.y > 3.5)
                {
                    //If they have collected a checkpoint...
                    if (CP == 1)
                    {
                        //Respawn them at the flag
                        tf.position = GameObject.Find("Checkpoint Flag").GetComponent<Transform>().position;
                    }
                    //Otherwise...
                    else
                    {
                        //Respawn them at the beginning of the level
                        SceneManager.LoadScene("Level2");

                    }
                }
            }

            //Otherwise...
            else
            {
                //If the player falls in the death zone...
                if (tf.position.y < -3.5)
                {
                    //If they have gathered a checkpoint...
                    if (CP == 1)
                    {
                        //Respawn them at the checkpoint
                        tf.position = GameObject.Find("Checkpoint Flag").GetComponent<Transform>().position;
                    }
                    //Otherwise...
                    else
                    {
                        //Respawn them at the beginning of the level
                        SceneManager.LoadScene("SampleScene");
                    }
                }
            }
            
            //Variable to hold player movement
            xMovement = Input.GetAxis("Horizontal") * speed;

            //Function to always check if the player jumps
            Jump();

            //Moves the player left and right depending on the axis value
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            tf.position += movement * speed * Time.deltaTime;

            //If the player presses the right arrow and they are on the ground...
            if (Input.GetKey(KeyCode.RightArrow) && isGrounded == true)
            {
                //Play the walking animation
                GetComponent<Animator>().Play("PlayerWalk");
                //Make them look right
                GetComponent<SpriteRenderer>().flipX = false;
            }
            //Otherwise if they press the left arrow and they are on the ground...
            else if (Input.GetKey(KeyCode.LeftArrow) && isGrounded == true)
            {
                //Play the walking animation
                GetComponent<Animator>().Play("PlayerWalk");
                //Turn the player to the left
                GetComponent<SpriteRenderer>().flipX = true;
            }

            //If the level currently playing is Level 2...
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                //If they press the down arrow...
                if (Input.GetKey(KeyCode.DownArrow) && isGrounded == false)
                {
                    //Play the jumping sound
                    GetComponent<AudioSource>().Play();
                    //Play the jumping animation
                    GetComponent<Animator>().Play("JumpUp");
                }
                //Otherwise...
                else
                {
                    //Play the idle animation
                    GetComponent<Animator>().Play("PlayerIdle1");
                }
            }

            //Otherwise...
            else
            {
                //If they press the up arrow...
                if (Input.GetKey(KeyCode.UpArrow) && isGrounded == false)
                {
                    //Play the jumping sound
                    GetComponent<AudioSource>().Play();
                    //Play the jumping animation
                    GetComponent<Animator>().Play("JumpUp");

                }
                //Otherwise...
                else
                {
                    //Play the idle animation
                    GetComponent<Animator>().Play("PlayerIdle1");
                }
            }

           



        }
    }

    //Function to make the player jump
    void Jump()
    {
        //If the level is Level 2...
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            //Jumping is the down arrow
            if (Input.GetKey(KeyCode.DownArrow) && isGrounded == true)
            {

                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -5f), ForceMode2D.Impulse);
            }
        }

        //Otherwise...
        else
        {
            //Jumping is the up arrow
            if (Input.GetKey(KeyCode.UpArrow) && isGrounded == true)
            {

                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            }
        }
    }
}
