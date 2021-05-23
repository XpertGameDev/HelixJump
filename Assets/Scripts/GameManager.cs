using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int best;
    public int score;

    public int currentStage = 0;

    public static GameManager singleton;




    void Awake()
    {
        if (singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);

        best = PlayerPrefs.GetInt("HighScore");
    }


    
    public void NextLevel()
	{
        Debug.Log("Next Level called");
	}

    public void RestartLevel()
	{
        Debug.Log("Game over");
	}

    public void AddScore(int scoreToAdd)
	{
        score += scoreToAdd;

		if (score > best)
		{
            best = score;

            PlayerPrefs.SetInt("HighScore", score);
		}
	}
}