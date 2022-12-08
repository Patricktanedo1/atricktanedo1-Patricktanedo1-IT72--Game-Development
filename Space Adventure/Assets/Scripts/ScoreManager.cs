using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;
    private float score;
  
     void Start()
    {
        score = 0;  
        scoreText.text = score.ToString();
        highScore.text  = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    void Update()
    {
       if(GameObject.FindGameObjectWithTag("Player") != null)
       {
        score += 1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();

         if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ((int)score));
            highScore.text = ((int)score).ToString();
        }
       } 
    }

    public void Reset(){
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
     }
}
