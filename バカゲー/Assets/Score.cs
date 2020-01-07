using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*==============================================================
 
    Scoreにつけるスクリプト
    ミサイルトの判定
     
================================================================*/

public class Score : MonoBehaviour
{
    int score;
    public Text scoreText; //スコア

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

   public void GetScore(int score)
    {
        this.score += score;
    }
}
