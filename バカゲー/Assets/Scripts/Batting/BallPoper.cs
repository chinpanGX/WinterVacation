using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPoper : MonoBehaviour
{
    public float changeTime;
    public float lounchTime;
    [SerializeField] private GameObject ball;
    private CameraManager cameraManager;
    private int ballNum = 30;
    public Text ballNumText;
    // Start is called before the first frame update
    void Start()
    {
        cameraManager = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        Invoke("LounchMissile", changeTime);
        ballNumText.text = "残りボール：" + ballNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(ball, transform.position, Quaternion.AngleAxis(90f, new Vector3(0f, 0f, 1.0f)));
        //    cameraManager.EnablePlayerCamera();
        //   // cameraManager.DisableBallCamera();
        //}
        ballNumText.text = "残りボール：" + ballNum.ToString();
    }

    public void CreateMIssile()
    {
        Invoke("M", changeTime);
        Invoke("LounchMissile", lounchTime);
    }

    private void M()
    {
        cameraManager.EnablePlayerCamera();
        cameraManager.DisableBallCamera();
    }

    private void LounchMissile()
    {
        Instantiate(ball, transform.position, Quaternion.AngleAxis(90f, new Vector3(0f, 0f, 1.0f)));
        ballNum--;
    }
}
