using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject pCamera;
    [SerializeField] private GameObject bCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnablePlayerCamera()
    {
        pCamera.GetComponent<Camera>().EnableCamera();
    }

    public void DisablePlayerCamera()
    {
        pCamera.GetComponent<Camera>().DisableCamera();
    }

    public void EnableBallCamera()
    {
        bCamera.GetComponent<Camera>().EnableCamera();
    }

    public void DisableBallCamera()
    {
        bCamera.GetComponent<Camera>().DisableCamera();
    }

    public void SetBall()
    {
        bCamera.GetComponent<BallTrackingCamera>().SetBall();
    }
}
