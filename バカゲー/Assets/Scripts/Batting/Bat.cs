using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    public float impulseMagnitude;
    [SerializeField] private GameObject bat;
    [SerializeField] private GameObject timeManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        timeManager.GetComponent<TimeManager>().SlowDown();
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        float batAngle = bat.GetComponent<Batting>().GetAngle();
        float batUp = bat.GetComponent<Batting>().GetUp();
        Vector3 vector = new Vector3(0.0f, 0.0f, 0.0f);
        vector.x = Mathf.Cos(Mathf.Deg2Rad * batAngle);
        vector.y = batUp / 45.0f;
        vector.z = -Mathf.Sin(Mathf.Deg2Rad * batAngle);
        Vector3 impulse = vector * impulseMagnitude;
        rb.AddForce(impulse, ForceMode.Impulse);
        
        //if (impulseMagnitude > 10.0f)
        //{
        //    Debug.Log("芯");
        //}
        //else
        //{
        //    Debug.Log("芯以外");
        //}
    }
}
