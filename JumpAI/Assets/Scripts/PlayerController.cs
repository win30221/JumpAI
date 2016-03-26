using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    
    bool grounded = true;

    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            jump();
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
            grounded = true;
        }
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}