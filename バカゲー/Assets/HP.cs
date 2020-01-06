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
    public int Maxhp = 500;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        hp = Maxhp;
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        hp -= 1;
        slider.value = (float)hp / (float)Maxhp; ;
    }

    //  ミサイルと衝突したときの判定
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag(" ミサイル "))   
        {
            hp -= 1; //攻撃で体力が減少
            slider.value = (float)hp / Maxhp; ;
            Destroy(hit.gameObject);
            if(hp == 0)
            {
                //ゲームオーバー
            }
        }
    }
}
