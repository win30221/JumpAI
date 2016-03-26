using UnityEngine;
using System.Collections;

public class NewBall : MonoBehaviour
{
    public GameObject ball;

    public void Spawn(float speed)
    {
        GameObject clone = (GameObject) Instantiate(ball, transform.position, transform.rotation);
        clone.GetComponent<BallController>().setSpeed(speed);
    }
}
