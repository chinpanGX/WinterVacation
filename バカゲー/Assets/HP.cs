using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*======================================================
    
    キャッチャー的なオブジェクトにつけるスクリプト

========================================================*/

public class HP : MonoBehaviour
{
    public int hp;  //  プレイヤーのHP 
    public int Maxhp = 500; //  マックス値
    public Slider slider;
    private Score score;
    private PopUpScore pScore;
    // Start is called before the first frame update
    void Start()
    {
        hp = Maxhp;
        slider.value = 1;
        pScore = GameObject.Find("PopupScore").GetComponent<PopUpScore>();
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        hp -= 1; //攻撃で体力が減少
        if (hp == 0)
        {
            pScore.SetScore(-31);
            score.GetScore(-30);
        }
        if(hp < 0)
        {
            hp = 0;
        }
        slider.value = (float)hp / Maxhp;
    }
}
