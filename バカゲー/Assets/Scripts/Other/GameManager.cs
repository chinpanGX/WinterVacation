using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Sound sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("SoundManager").GetComponent<Sound>();
        sound.PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReLoad();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    private void ReLoad()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    private void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif
    }
}
