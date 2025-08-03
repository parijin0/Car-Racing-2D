using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Manager : MonoBehaviour
{
    public int score = 0;
    
    public Text scoreText;
    public Text highScoreText;
    public Text lastScoreText;

    public static int lastScore = 0;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
        //StartCoroutine(Reload());
        highScore = PlayerPrefs.GetInt("high_score",0);
        highScoreText.text = "HighScore: " + highScore.ToString();
        lastScoreText.text = "LastScore: " + lastScore.ToString();
    }

    // Update is called once per frame
        void Update()
    {
       scoreText.text = score.ToString();
       if(score>highScore)
       {
           highScore=score;
           PlayerPrefs.SetInt("high_score", highScore);
       }
    }

    IEnumerator Score()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.8f);
            score = score + 1;
            lastScore = score;
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(Random.Range(5,10));
        SceneManager.LoadScene("Game");
    }
}