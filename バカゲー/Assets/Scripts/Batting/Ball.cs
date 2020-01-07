using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Explosion explosion;
    private CameraManager cameraManager;
    private GameObject missilePoper;
    private Sound sound;
    private Score score;
    private PopUpScore pScore;

    int count = 0;
    public float power;
    private bool isFoul = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 100.0f));
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(power, -1000.0f, 0.0f));
        cameraManager = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        explosion = GameObject.Find("EffectManager").GetComponent<Explosion>();
        missilePoper = GameObject.Find("BallPoper");
        sound = GameObject.Find("SoundManager").GetComponent<Sound>();
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
        pScore = GameObject.Find("PopupScore").GetComponent<PopUpScore>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bat":
                cameraManager.EnableBallCamera();
                cameraManager.DisablePlayerCamera();
                rb.useGravity = true;
                sound.PlayBattingSE();
                cameraManager.SetBall();
                break;

            case "Field":
                count++;
                if (count > 1)
                {
                    return;
                }
                sound.PlayExplosionSE();
                explosion.CreteExplosion();
                missilePoper.GetComponent<BallPoper>().CreateMIssile();
                pScore.SetMissilePosition(transform.position);
                score.GetScore(-1);
                pScore.SetScore(-1);
                break;

            case "PoorField":
                count++;
                if (count > 1)
                {
                    return;
                }
                sound.PlayExplosionSE();
                explosion.CreteExplosion();
                missilePoper.GetComponent<BallPoper>().CreateMIssile();
                pScore.SetMissilePosition(transform.position);
                score.GetScore(2);
                pScore.SetScore(2);
                break;

            case "LuxuryField":
                count++;
                if (count > 1)
                {
                    return;
                }
                sound.PlayExplosionSE();
                explosion.CreteExplosion();
                missilePoper.GetComponent<BallPoper>().CreateMIssile();
                pScore.SetMissilePosition(transform.position);
                score.GetScore(4);
                pScore.SetScore(4);
                break;

            case "OutAria":
                sound.PlayExplosionSE();
                explosion.CreteExplosion();
                missilePoper.GetComponent<BallPoper>().CreateMIssile();
                pScore.SetMissilePosition(transform.position);
                score.GetScore(-1);
                pScore.SetScore(-1);
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "foul")
        {
            cameraManager.EnableBallCamera();
            cameraManager.DisablePlayerCamera();
            cameraManager.SetBall();
            isFoul = true;
        }
    }
}
