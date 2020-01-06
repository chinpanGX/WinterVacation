using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*=====================================================
 
    ファールゾーンの判定
    Foulcollisionにつける

======================================================*/

public class FoulZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //  マップから離れたとき
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "foul")
        {
            //     再スタート
        }
    }
}
