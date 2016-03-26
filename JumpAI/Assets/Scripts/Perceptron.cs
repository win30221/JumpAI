using UnityEngine;
using System.Collections;

public class Perceptron : MonoBehaviour {

    public float maxW = 0.1f, minW = 0.0f;

    public Perceptron()
    {
        
    }

    public bool getJump(GameObject player, GameObject[] balls)
    {
        bool check = false;
        foreach (GameObject ball in balls)
        {
            BallController ballScript = ball.GetComponent<BallController>();

            /*if (!(ball.transform.position.x - transform.position.x >= ballScript.speed * maxW &&
                ball.transform.position.x - transform.position.x <= ballScript.speed * (minW + 0.05f)))
            {
                check = false;
                break;
            }*/
            if (ball.transform.position.x > player.transform.position.x) {
                if (!(ball.transform.position.x - player.transform.position.x >= ballScript.speed * minW))
                {
                    check = true;
                    break;
                }
            }
        }

        return check;
    }

    public void tranning(bool safe, bool over)
    {
        if (!safe)
        {
            if (over)
            {
                minW -= 0.01f;
            }
            else
            {
                minW += 0.01f;
            }
        }
        print(minW);
    }

    /*public void tranning(bool safe)
    {
        if (!safe)
        {
            if (minW > maxW && touchBall)
            {
                minW -= 0.01f;
                minCheck = true;
            }
            else
            {
                maxW += 0.01f;
                minW = maxW;
            }
        } else
        {
            if (!minCheck)
            {
                minW += 0.01f;
            }
        }
    }*/
}