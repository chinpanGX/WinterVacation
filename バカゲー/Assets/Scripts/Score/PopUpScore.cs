using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopUpScore : MonoBehaviour
{

    public Text popupText;
    public GameObject ballCamera;
    // Start is called before the first frame update
    void Start()
    {
        popupText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMissilePosition(Vector3 pos)
    {
        Vector3 missilePosition = pos;
        missilePosition.y += 50.0f;
        gameObject.transform.position = pos;
        Vector3 p = ballCamera.transform.position;
        p.y = transform.position.y;
        transform.LookAt(p);
        Vector3 scale = transform.localScale;
        scale.x = -1;
        transform.localScale = scale;
    }

    public void SetScore(int score)
    {
        popupText.text = score.ToString();
        Invoke("ResetScore", 2.0f);
    }

    private void ResetScore()
    {
        popupText.text = "";
    }
}
