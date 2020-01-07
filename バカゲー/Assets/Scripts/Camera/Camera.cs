using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public void EnableCamera()
    {
        gameObject.SetActive(true);
    }

    public void DisableCamera()
    {
        gameObject.SetActive(false);
    }
}
