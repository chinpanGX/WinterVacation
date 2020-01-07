using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreteExplosion()
    {
        GameObject ball = GameObject.Find("MissileCollider(Clone)");
        GameObject effect = Instantiate(explosion, ball.transform.position, Quaternion.AngleAxis(-180f, new Vector3(0f, 1.0f, 0f)));
        Destroy(ball);
        Destroy(effect, 2.0f);
    }
}
