using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{
    
    bool grounded = true;
    bool touchBall = false;

    public Perceptron perceptron;

    void Start()
    {
        perceptron = new Perceptron();
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Ball").Length > 0)
        {
            if (perceptron.getJump(gameObject, GameObject.FindGameObjectsWithTag("Ball")))
            {
                jump();
            }
        }
    }

    void jump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 15f);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {

            if (!touchBall && !grounded)
            {
                if (other.transform.position.x > transform.position.x)
                {
                    perceptron.tranning(true, false);
                }
                else
                {
                    perceptron.tranning(true, true);
                }
            }
            grounded = true;
            touchBall = false;
        }
        if (other.tag == "Ball")
        {
            if (other.transform.position.x > transform.position.x)
            {
                perceptron.tranning(false, false);
            } else
            {
                perceptron.tranning(false, true);
            }
            
            touchBall = true;
        }
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}