using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    private float time;
    public NewBall AI;
    public NewBall Player;

    public int aiScore, playerScore;

    public Text AIScore;
    public Text PlayerScore;

    void Start()
    {
        time = 1;
        aiScore = 0;
        playerScore = 0;
    }
    
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                float speed = Random.Range(10.0f, 30.0f);
                AI.Spawn(speed);
                Player.Spawn(speed);
            }
        }
        else
        {
            time = Random.Range(0.5f, 1.0f); ;
        }
    }

    public void getAIScore()
    {
        aiScore++;
        if (aiScore >= 50)
        {
            AIScore.color = Color.red;
        }
        else if (aiScore >= 25)
        {
            AIScore.color = Color.blue;
        }
        AIScore.text = "AI Score: " + aiScore.ToString();
    }

    public void getPlayerScore()
    {
        playerScore++;
        if (playerScore >= 50)
        {
            PlayerScore.color = Color.red;
        }
        else if (playerScore >= 25)
        {
            PlayerScore.color = Color.blue;
        }
        PlayerScore.text = "Player Score: " + playerScore.ToString();
    }
}