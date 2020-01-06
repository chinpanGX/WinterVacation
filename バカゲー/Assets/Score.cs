using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*==============================================================
 
    mapcollisionにつけるスクリプト
    ミサイルトの判定
     
================================================================*/

public class Score : MonoBehaviour
{
    public int hp;  //  マップのHP
    public int MaxHp = 1000;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        hp = MaxHp;
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        hp -= 1; //攻撃で体力が減少
        slider.value = (float)hp / MaxHp; ;
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag(" ミサイル "))
        {
            hp -= 1; //攻撃で体力が減少
            slider.value = (float)hp / MaxHp; ;
            Destroy(hit.gameObject);
            if(hp == 0)
            {
                //ゲームクリア
            }
        }
    }
}
