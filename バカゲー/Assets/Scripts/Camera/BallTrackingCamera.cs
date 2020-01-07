using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrackingCamera : MonoBehaviour
{
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(ball)
        {
            Vector3 pos = ball.transform.position;
            pos.x -= 250.0f;
            pos.y += 100.0f;
            transform.position = pos;
        }
    }

    public void SetBall()
    {
        ball = GameObject.Find("MissileCollider(Clone)");
    }
}
