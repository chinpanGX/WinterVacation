using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batting : MonoBehaviour
{

    private bool isSwing = false;
    private float rot = 0.0f;
    private float up = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rot, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isSwing = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            up += 0.5f;
            if(up > 25)
            {
                up = 25;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            up += -0.5f;
            if(up < -15)
            {
                up = -15;
            }
        }
        Swing();
    }

    private void Swing()
    {
        if (isSwing)
        {
            transform.Rotate(new Vector3(0, -6.6f, 0));
            if (transform.localEulerAngles.y > 0.0f && transform.localEulerAngles.y < 180.0f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0.0f, rot, 0.0f));
                isSwing = false;
            }
        }
    }

    public float GetAngle()
    {
        return transform.localEulerAngles.y + 90.0f;
    }

    public float GetUp()
    {
        return up;
    }
}
