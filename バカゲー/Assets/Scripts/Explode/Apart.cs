using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apart : MonoBehaviour
{

    float force = 5000f;             // 壊れるときに（爆発的に）かかる力
    private Vector3 missilePos;
  

    // --- 壊れる処理。子オブジェクトを取得してそれぞれ ExplodePart させる ------
    public void Break()
    {
        var transformArray = GetComponentsInChildren<Transform>();
        for(int i = 0; i < transformArray.Length; i++)
        {
            ExplodePart(transformArray[i], force);
        }
    }


    // --- 部品にばらしてRigidbodyを付けてふっとばす --------------------------
    private void ExplodePart(Transform part, float force)
    {
        part.transform.parent = null;
        Rigidbody rb = part.gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
        float randomx = Random.value;
        float randomy = Random.value;
        float randomz = Random.value;
        //rb.AddForce(new Vector3(force * randomx, force * randomy, force * randomz));
        rb.AddExplosionForce(force, missilePos, 0f);
        Destroy(part.gameObject, 5f);
    }


    // --- 衝突検出 ----------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            missilePos = collision.transform.position;
            Break();
        }
    }
}
