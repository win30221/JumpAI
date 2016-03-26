using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
    
    public float speed;
	
    void Start()
    {
        //speed = Random.Range(10.0f, 30.0f);
        //speed = 10;
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            if (this.gameObject.tag == "Ball")
            {
                gc.getAIScore();
            }
            else if (this.gameObject.tag == "PlayerBall")
            {
                gc.getPlayerScore();
            }

            Destroy(this.gameObject);
        }
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
