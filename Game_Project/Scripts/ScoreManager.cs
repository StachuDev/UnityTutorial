using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

   public static ScoreManager instance;
   public TMP_Text scoreText;
   public TMP_Text highscoreText;

   int score = 0;
   int highscore = 0;

   private void Awake(){
      instance = this;
   }

   void Start() {
      highscore = PlayerPrefs.GetInt("highscore", 0);
    scoreText.SetText("SCORE: " + score.ToString());
    highscoreText.SetText("HIGHSCORE: " + highscore.ToString());
   }

   public void AddPoint(){
      score++;
      scoreText.SetText("SCORE: " + score.ToString());
      if(highscore < score){
      PlayerPrefs.SetInt("highscore", score);
      }
      // highscoreText.SetText("HIGHSCORE: " + highscore.ToString());
   }
   void Update(){
   }
}
